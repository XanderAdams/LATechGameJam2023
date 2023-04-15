using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerManager playerManager;
    public Animator POneanimator;
    public Animator PTwoanimator;

    private Rigidbody2D rb; //Getting the rigidbody

    public float speed = 2; //Movement Speed value
    public float jump = 14f; //Jump value


    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;


    private int jumpCounter;

    public bool canDash = true;
    public float dashPower = 20f;
    public float dashTime = 0;
    public float maxDash = 104;
    private float lastXDir = 1 ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Automatically gathers the component off of the object the script is on
        
    }

    void FixedUpdate()
    {
        dashTime -= 1;
    }
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal"); //Getting the direction of the object

        POneanimator.SetFloat("Speed", Mathf.Abs(dirX));

        if (dashTime < 0)
            rb.velocity = new Vector2(dirX * speed, rb.velocity.y); //Moving in that direction using A or Dd

        if (dirX > 0)
            lastXDir = 1;
        if (dirX < 0)
            lastXDir = -1;

        canDash = (dashTime < 0);

        if (Input.GetKey(KeyCode.LeftShift) && canDash && playerManager.POneActive == true)
        {
            dashTime = maxDash;
            canDash = false;
            Debug.Log("Dash");
            rb.AddForce((transform.right * lastXDir) * dashPower, ForceMode2D.Impulse);
            POneanimator.SetBool("IsDashing", true);

        }

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(2.95f, 0.45f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jumpCounter -= 1;
            rb.velocity = new Vector2(rb.velocity.x, jump); //Movement for up
            POneanimator.SetBool("IsJumping", true);

            

        } //End of Jump


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 5);
        Debug.DrawRay(transform.position, Vector2.down, Color.green);

        if (hit.collider == gameObject.CompareTag("Ground"))
        {
            jumpCounter = 2;

           
            canDash = true;
            
            Debug.Log("Ground");
        }

    }// End of Update
    
    /*void Dash()
    {
        rb.AddForce(new Vector2(-5f, 0f), ForceMode2D.Impulse);
    }*/
    

} //End of Class
