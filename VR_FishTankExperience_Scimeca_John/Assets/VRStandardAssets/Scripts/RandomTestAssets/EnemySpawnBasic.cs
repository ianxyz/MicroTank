using UnityEngine;
using System.Collections;

public class EnemySpawnBasic : MonoBehaviour {

    public Rigidbody enemy;

    public float enemySpeed = 2f;


    void SpawnEnemy()
    {



        


        // Instantiate the enemy at the position and rotation of this transform

        Rigidbody enemyClone = (Rigidbody)Instantiate(enemy, transform.position, transform.rotation);

        enemyClone.AddForce(transform.forward * enemySpeed);




    }


   

    void Start() {

   
            InvokeRepeating("SpawnEnemy", 2, 2);
        
    }


}
