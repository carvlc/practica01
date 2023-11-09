using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private void Start() {
        speed = 10;
    }
    void Update()
    {
        // se usa Horizonal para detectar las teclas izquierda - derecha / a - d
        transform.Translate(Input.GetAxis("Horizontal")* speed * Time.deltaTime,0,0);
    }
}
