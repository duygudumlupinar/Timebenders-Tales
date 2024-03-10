using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;

    public float speed = 3f;
    public float jumpPower = 5f;

    private Rigidbody rb;
    private Animator animator;
    private float horizontalMovement;
    private float verticalMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        if (verticalMovement != 0f)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, verticalMovement * speed);
        }

        if (horizontalMovement != 0f)
        {
            rb.velocity = new Vector3(horizontalMovement * speed, rb.velocity.y, 0f);
        }

        if (!(verticalMovement == 0f && horizontalMovement == 0f))
        {
            var tanangle = Mathf.Atan2(-horizontalMovement, -verticalMovement) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, tanangle, 0);
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && CheckIfGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
        }


        if (!(verticalMovement == 0f && horizontalMovement == 0f))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

    bool CheckIfGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);
    }
}
