using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public Rigidbody2D rigidbody;

    public PlayerMovement playerMovement;

    public bool POneActive;
    //public bool PTwoActive;

    // Start is called before the first frame update
    void Start()
    {
        if(POneActive == true)
        {
            PlayerTwo.SetActive(false);
            PlayerOne.SetActive(true);
        }
        else
        {
            PlayerTwo.SetActive(true);
            PlayerOne.SetActive(false);
        }
       
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            if (POneActive == true)
            {
                PlayerOne.SetActive(false);
                POneActive = false;
                PlayerTwo.SetActive(true);
                playerMovement.speed = 6;
                playerMovement.jump = 18;
                
            }
            else
            {
                PlayerOne.SetActive(true);
                POneActive = true;
                PlayerTwo.SetActive(false);

                playerMovement.speed = 10;
                playerMovement.jump = 14;
            }
        }

        
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dark")
        {
            PlayerOne.SetActive(false);
            POneActive = false;
            PlayerTwo.SetActive(true);
            playerMovement.speed = 6;
            playerMovement.jump = 18;

        }
        
        if (collision.gameObject.tag == "Light")
        {
            PlayerOne.SetActive(true);
            POneActive = true;
            PlayerTwo.SetActive(false);

            playerMovement.speed = 10;
            playerMovement.jump = 14;
        }
    }
}
