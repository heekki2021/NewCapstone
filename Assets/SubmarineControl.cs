using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;
    private float horizontal;
    private bool isFacingRight = true;

    private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Jump();
    //    RightLeftMove();

    //}

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Jump();
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = jumpPower * Vector2.down;

        }
    }

   private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;  
        }
    }

    //void RightLeftMove()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        transform.position += moveSpeed * Time.deltaTime * Vector3.left; 
    //    }else if(Input.GetKeyDown(KeyCode.D)) 
    //    { transform.position -= moveSpeed * Time.deltaTime * Vector3.left; }
    //}
}
