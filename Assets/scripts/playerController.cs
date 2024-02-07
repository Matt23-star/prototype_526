using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 10f;
    public float jumpForce;
    //public Transform player;
    //public LayerMask ground;
    //public float groundCheckRadius = 0.35f;
    //public bool isLanded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        if(horizontalMove != 0)
        {
            //rb.velocity = new Vector2 (horizontalMove * speed * Time.deltaTime, rb.velocity.y);
            rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
        }

        //isLanded = Physics.CheckSphere(player.position, groundCheckRadius, ground);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
        }
    }
}
