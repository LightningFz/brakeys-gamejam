using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float MovingSpeed = 20f;

    private float horizontal;
    private float vertical;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movemnet;
    Vector2 mousePos;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getInput();
        move();
    }
    void getInput()
    {
        movemnet.x = Input.GetAxisRaw("Horizontal");
        movemnet.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void move()
    {
        rb.MovePosition(rb.position + movemnet * MovingSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
