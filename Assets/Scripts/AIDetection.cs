using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDetection : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    public GameObject Detection;
    public float DetectRange;

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {

        }
    }
    private bool CheckTargetVisible()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Player, DetectRange);
        if hit.collider != Player
    }*/
}
