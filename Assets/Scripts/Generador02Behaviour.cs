using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador02Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemy02;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
    [SerializeField] private float speedZ;
    [SerializeField] private float limitNumberEnemies;// variable indica la cantidad limite de eneimgos2 que sera creados
    private float enemyCounter; //contador para controlar la cantidad de enemigos

    void Start()
    {
        enemyCounter = 0;
        InvokeRepeating("GenerateEnemy02", initTime, repeatTime);

    }

    private void Update()
    {
        MoveGenerator02();
    }

    public void GenerateEnemy02()
    {
        // este if es para controlar que la cantidad de enemigos de enemigos creados
        if (enemyCounter < limitNumberEnemies)
        {
            Instantiate(enemy02, transform.position, transform.rotation);
        }
        // este if es para que la variable enemyCounter no se siga incrementando despues de alcanzar el numbero limite
        if (enemyCounter < limitNumberEnemies)
        {
            enemyCounter += 1;
        }

    }

    public void MoveGenerator02()
    {
        if (transform.position.z < -4.5f || transform.position.z > 4.5f)
        {
            speedZ *= -1;
        }
        transform.Translate(0, 0, speedZ * Time.deltaTime);
    }
}
