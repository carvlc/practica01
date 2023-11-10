using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] GameObject playerBullet;
    private float speedPlayer;
    private float limitRangeX;
    private void Start()
    {
        speedPlayer = 10f;
        limitRangeX = 4.5f;
    }
    void Update()
    {
        MovePlayer();
        Fire();
    }

    public void MovePlayer()
    {
        if (transform.position.x < -limitRangeX)
        {
            transform.position = new Vector3(-limitRangeX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > limitRangeX)
        {
            transform.position = new Vector3(limitRangeX, transform.position.y, transform.position.z);

        }
        // se usa Horizonal para detectar las teclas izquierda - derecha / a - d

        transform.Translate(Input.GetAxis("Horizontal") * speedPlayer * Time.deltaTime, 0, 0);
    }

    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, transform.position, transform.rotation);

        }
    }
}
