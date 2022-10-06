using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private float vertical;
    public float speed;
    public float jumpPower;
    public bool faceRight = true;

    public LayerMask groundLayer;
    private Animator anim;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public float extraHeightTest;

    Vector2 vecGravity;

    private bool isJump = false;

    private float jumpTimeCounter;
    public float jumpTime;

    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();       
        bc = GetComponent<BoxCollider2D>(); 
    }

    // Update is called once per frame
    void Update()
    {

        // if(Input.GetKeyDown(KeyCode.J)){
        //     Debug.Log("SHAKE");
        //     cameraShake.Instance.ShakeCamera(5f, 1f);
        // }

        vertical = Input.GetAxisRaw("Vertical");
        if(vertical == 1 && isGrounded() && !isJump && anim.GetBool("isDied") == false){
            isJump = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpPower;
        }

        if(anim.GetBool("isDied") == true){
            rb.velocity = new Vector2(0,0);
        }

        if(vertical == 1 && isJump){
            if(jumpTimeCounter > 0){
                rb.velocity = Vector2.up * jumpPower;
                jumpTimeCounter -= Time.deltaTime;
            }else{
                isJump = false;
            }
        }

        if(vertical != 1){
            isJump = false;
        }
    }

    void FixedUpdate()
    {
        // return -1 0 1 direction

        horizontal = Input.GetAxisRaw("Horizontal");
        if(anim.GetBool("isDied") == false){
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
            anim.SetBool("isRunning",horizontal != 0);
            flip();
        }

    }

    private bool isGrounded(){
        RaycastHit2D rayCastHit = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, extraHeightTest, groundLayer);

        return rayCastHit;
    }

    private void flip(){
        if(faceRight && horizontal < 0f || !faceRight && horizontal > 0f){
            faceRight = !faceRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
