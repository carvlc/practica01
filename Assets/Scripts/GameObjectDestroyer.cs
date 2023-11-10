using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDestroyer : MonoBehaviour
{
    private float limitZ;
    private float limitX;
    private void Start() {
        limitX = 5.5f;
        limitZ = 5.5f;
    }
    void Update()
    {
        if (transform.position.x > limitX || transform.position.x < -limitX)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > limitZ || transform.position.z < -limitX)
        {
            Destroy(gameObject);
        }
    }
}
