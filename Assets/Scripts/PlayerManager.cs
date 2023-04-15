using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject PlayerOne;
    public GameObject PlayerTwo;

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
    void Update()
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
                /*Debug.Log("Test1");
                PlayerOne.SetActive(false);
                Debug.Log("Test2");
                POneActive = false;
                Debug.Log("Test3");
                PlayerTwo.SetActive(true);
                Debug.Log("Test4");
                PTwoActive = true;
                Debug.Log("Test5");*/
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
    }
}
