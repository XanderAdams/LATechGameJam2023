using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneCombat : MonoBehaviour
{
    public GameObject Melee;
    public bool Attack = false;
    public float AttackTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Melee.SetActive(true);
            Attack = true;




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
