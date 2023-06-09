using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIDetection : MonoBehaviour
{
    private float Speed = 0f;
    public float wantedSpeed = 200f;
    public Transform target;
    
    public float nextWayPointDis = 3f;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    public bool PlayerInArea = false;



    Seeker seeker;
    Rigidbody2D rb;

    void Start()
    {
        
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        
        InvokeRepeating("UpdatePath", 0f, .5f);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Speed = wantedSpeed;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           // Speed = 0f;
        }
    }



    void UpdatePath()
    {
        if (seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }
    }        

            void OnPathComplete(Path p)
            {
                if (!p.error)
                {
                    path = p;
                    currentWaypoint = 0;
                }
            }

            void FixedUpdate()
            {
                if (path == null)
                    return;

                if (currentWaypoint >= path.vectorPath.Count)
                {
                    reachedEndOfPath = true;
                } else
                {
                    reachedEndOfPath = false;
                }

                Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
                Vector2 force = direction * Speed * Time.deltaTime;


                rb.AddForce(force);

                float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

                if (distance < nextWayPointDis)
                {
                    currentWaypoint++;
                }
            }
}
