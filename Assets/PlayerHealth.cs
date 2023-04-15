using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10;
    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Test");
            health -= 1;
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }


    }
}
