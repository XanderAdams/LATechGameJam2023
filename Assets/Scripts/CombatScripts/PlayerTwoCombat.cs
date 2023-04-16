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
    public float BulletCount = 5.0f;
    private bool Shot;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
            Shot = true;
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

        if (Shot == true)
        {
            BulletTime -= Time.deltaTime;
            if( BulletTime < 0)
            {
                if (BulletCount < 5.0f)
                {
                    BulletCount += 1;
                    BulletTime = 0.5f;
                }
            }
        }
    }

    void Shoot()
    {
        if (BulletCount > 0)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            BulletCount--;

            FindObjectOfType<AudioManagerX>().play("Spell Shot");
        }
    }
}
