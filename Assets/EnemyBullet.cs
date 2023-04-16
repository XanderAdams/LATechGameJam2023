using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigidbody2D;
    private float BulletTime = 3;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.velocity = transform.right * -speed;
    }

    void Update()
    {
        BulletTime -= Time.deltaTime;
        if (BulletTime <= 0)
        {
            Destroy(gameObject);

            BulletTime = 2;
        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == ("Ground"))
        {
            Destroy(gameObject);

        }
    }
    
}
