using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private float speedZ;
    // Start is called before the first frame update
    void Start()
    {
        speedZ = 6;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speedZ * Time.deltaTime);
    }
}
