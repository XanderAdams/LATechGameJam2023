using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform Target;
    public Transform gun;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool Detect = false;
    public float FireRate = 1f;
    private float FireNext;
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation
             (Target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        if (Detect == true && Time.time > FireNext)
        {
            FireNext = Time.time + FireRate;
            Shoot();
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            Detect = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            Detect = false;
        }
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}

