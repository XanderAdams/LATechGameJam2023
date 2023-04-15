using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform target;
    public Transform gun;
    public float Range;
    Vector2 Direction;

    void update()
    {
        

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 20);
        Debug.Log(hit.transform.name);
        Debug.DrawRay (transform.position, -Vector2.up, Color.red, 20);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
