using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform Target;
    public Transform gun;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float Range;
    public bool Detect = false;
    
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation
             (Target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Detect = true;
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Detect = false;
            }
        }

        if(Detect = true)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }

}

