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
            playerMovement.speed = 10;
            playerMovement.jump = 14;
        }
        else
        {
            PlayerTwo.SetActive(true);
            PlayerOne.SetActive(false);
            playerMovement.speed = 6;
            playerMovement.jump = 18;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.dashTime < 0)
        {
            playerMovement.POneanimator.SetBool("IsDashing", false);
        }



    }

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

        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Test");
            playerMovement.POneanimator.SetBool("IsJumping", false);
            playerMovement.PTwoanimator.SetBool("IsJumping", false);
            playerMovement.POneanimator.SetBool("IsDashing", false);
        }
    }
}
