using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody rb;
    public Vector3 input;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = 0;
        input.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        movePlayer(input);
    }

    void movePlayer(Vector3 direction)
    {
        if (direction != new Vector3(0, 0, 0))
        {
            rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
            rb.rotation = Quaternion.LookRotation(direction);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
