using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneCombat : MonoBehaviour
{
    public GameObject Melee;
    public GameObject PlayerOne;
    public bool Attack = false;
    public float AttackTime = 0.5f;
    public GameObject PlayerTwo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Melee.SetActive(true);
            Attack = true;




        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerOne.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            PlayerTwo.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        if (Attack == true)
        {
            AttackTime -= Time.deltaTime;
            if (AttackTime < 0)
            {
              
                Melee.SetActive(false);
                Attack = false;
                AttackTime = 0.5f;
            }



        }
    }
}
