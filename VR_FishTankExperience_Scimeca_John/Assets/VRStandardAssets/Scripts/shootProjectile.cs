using UnityEngine;
using System.Collections;

public class shootProjectile : MonoBehaviour
{


    public Rigidbody projectile;

    public float pSpeed = 2f;



    void Shoot()
    {



        // Put this in your update function


        // Instantiate the projectile at the position and rotation of this transform

        Rigidbody projectileClone = (Rigidbody)Instantiate(projectile, transform.position, transform.rotation);

        projectileClone.AddForce(transform.forward*100);

        


    }



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


}
