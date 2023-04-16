using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3;
    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack"))
        {
            Debug.Log("Test");
            health -= 1;
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }

        if (collision.CompareTag("POneAttack"))
        {
            health -= 5;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        } 

        
    }
}
