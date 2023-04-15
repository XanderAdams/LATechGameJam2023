using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoCombat : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject PlayerTwo;
    public GameObject PlayerOne;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

     
    }

    void Shoot()
    {
        
        
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
          
        
    }
}
