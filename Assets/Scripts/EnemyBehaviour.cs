using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;
    [SerializeField]
    private int enemyType; // 1:enemigo01 2:enemigo02
    private float speedXEnemy02; //
    private float speedX;
    private float speedZ;
    private float randomTime;
    // Start is called before the first frame update
    void Start()
    {
        speedX = 2f;
        speedZ = 2f;
        speedXEnemy02 = 4f;
        randomTime = 0;

        switch (enemyType)
        {
            case 1:
                {
                    InvokeRepeating("ShootBullet", 0, 2);
                    break;
                }
            case 2:
                {
                    Invoke("ShootBullet", randomTime);
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    public void ShootBullet()
    {
        // si es Enemigo01
        Instantiate(enemyBullet, transform.position, transform.rotation);

        // si es Enemigo02
        if (enemyType == 2)
        {
            randomTime = Random.Range(1, 3);
            Invoke("ShootBullet", randomTime);
        }
    }

    public void MoveEnemy()
    {
        switch (enemyType)
        {
            case 1:
                {
                    transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
                    break;

                }
            case 2:
                {
                    if (transform.position.x < -4.5f || transform.position.x > 4.5f)
                    {
                        speedXEnemy02 *= -1;
                    }
                    transform.Translate(-speedXEnemy02 * Time.deltaTime, 0, 0);
                    break;
                }
        }
    }
}
