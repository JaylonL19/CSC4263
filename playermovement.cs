using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Animator animator;

    void Start()
    {

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
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.right;

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.left;

        }
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetFloat("xDirection", direction.x);
        animator.SetFloat("yDirection", direction.y);
        print(animator.GetFloat("xDirection"));
    }
}
