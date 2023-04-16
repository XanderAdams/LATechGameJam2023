using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoCombat : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject PlayerTwo;
    public GameObject PlayerOne;

    private float BulletTime = 2.0f;
    public float FireRate = 1f;
    private float FireNext;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && Time.time > FireNext)
        {
            FireNext = Time.time + FireRate;
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

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        
    }

    void Shoot()
    {
        
        
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            

            FindObjectOfType<AudioManagerX>().play("Spell Shot");
        
    }
}
