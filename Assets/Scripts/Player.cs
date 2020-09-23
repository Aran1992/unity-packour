using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vecocity;
    public float jumpForce;
    Rigidbody2D body;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(vecocity, body.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            body.AddForce(new Vector2(0, jumpForce));
            animator.SetBool("run2jump", true);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        animator.SetBool("run2jump", false);
    }
}
