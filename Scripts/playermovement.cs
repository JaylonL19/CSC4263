using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float jumpHeight;
    public float speed;
    private Vector2 direction;
    private Animator animator;
    private Rigidbody2D rb;

  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Initialize the animator
    }

    void Update()
    {
        TakeInput();
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        SetAnimatorMovement(direction);
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }

        
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetFloat("xDirection", direction.x);
        animator.SetFloat("yDirection", direction.y);
        print(animator.GetFloat("xDirection"));
    }
}
