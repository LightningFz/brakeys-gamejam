using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float MovingSpeed;

    public float horizontal;
    public float vertical;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        move();
    }
    void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    void move()
    {
        rb.velocity = new Vector2(horizontal * MovingSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, vertical * MovingSpeed);
    }
}
