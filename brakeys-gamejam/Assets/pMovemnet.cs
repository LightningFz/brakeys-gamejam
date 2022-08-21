using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovemnet : MonoBehaviour
{
    public float runSpeed = 40;
    public float jumpPower = 5;
    [SerializeField] private float checkRadius;
    public int maxJumps = 1;


    public bool isFacingRight = true;
    private bool _isJumping = false;
    private bool isGrounded;
    private float horizontal;
    private int jumpCount;
    private float direction;


    //[SerializeField] private Transform cellingCheck;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundObject;

    Rigidbody2D rb;
    BoxCollider2D coll;
    SpriteRenderer sprite;
    Animator anim;
    //[SerializeField] private Transform alltransform;
    //PlayerAimWeapon weaponAim;
    //public static playerMovement Instance { get; private set; }

    private void Awake()
    {
        //Instance = this;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        //weaponAim = GetComponentInChildren<PlayerAimWeapon>();
    }
    private void Start()
    {
        jumpCount = maxJumps;
    }

    void Update()
    {
        faceRight();
        getInput();
    }

    private void FixedUpdate()
    {
        Grounded();
        move();
        notMoving();
    }

    private void Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
        if (isGrounded)
        {
            anim.SetBool("isJumping", false);
            jumpCount = maxJumps;
        }
    }

    public void faceRight()
    {
        if (horizontal < 0 && isFacingRight)
        {
            Flip();
            //weaponAim.localAim = false;
        }
        else if (horizontal > 0 && !isFacingRight)
        {
            Flip();
            //weaponAim.localAim = true;
        }
    }
    private void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("takeOf");
            anim.SetBool("isJumping", true);
            _isJumping = true;
        }

    }

    private void notMoving()
    {
        if (horizontal == 0)
        {
            anim.SetBool("isRunning", false);
        }
    }

    private void move()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);
        anim.SetBool("isRunning", true);
        if (_isJumping && jumpCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
            anim.SetBool("isJumping", true);
            jumpCount--;
        }
        _isJumping = false;
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180, 0f);
    }


}
