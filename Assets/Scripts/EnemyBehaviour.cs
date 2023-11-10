using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;
    private float speedX;
    private float speedZ;
    // Start is called before the first frame update
    void Start()
    {
        speedX = 2;
        speedZ = 2;
        InvokeRepeating("ShootBullet",0,2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, 0 , speedZ * Time.deltaTime );
    }

    public void ShootBullet()
    {
        Instantiate(enemyBullet, transform.position, transform.rotation); 
    }
}
