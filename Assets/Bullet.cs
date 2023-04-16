using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rigidbody2D;
    public PlayerTwoCombat playerTwoCombat;
    private float BulletTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.velocity = transform.right * speed;
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
        if (collision.gameObject.tag == ("Enemy"))
        {
            Destroy(gameObject);
            
        }

        /*if (collision.gameObject.tag == ("Ground"))
        {
            Destroy(gameObject);
            
        }*/

        if (collision.gameObject.tag == ("Light"))
        {
            Destroy(gameObject);
            
        }

    }

}