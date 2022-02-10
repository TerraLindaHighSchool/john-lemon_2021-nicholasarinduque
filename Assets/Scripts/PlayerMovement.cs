using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    private Animator m_Animator;
    private Rigidbody rb;
    private Vector3 moveDirection;
    private Quaternion rotation;
    private bool isWalking;
    

    [SerializeField] private float turnSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rotation = Quaternion.identity;
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        // Get user input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Use user input to set direction player will move
        moveDirection.Set(horizontal, 0f, vertical);
        moveDirection.Normalize();

        // Set animator to walking or idle depending on user input

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool("IsWalking", isWalking);
        // Assign roation towards move direction 
        Vector3 desiredDirection = Vector3.RotateTowards(transform.forward, moveDirection,
            turnSpeed * Time.deltaTime, 0f);
        rotation = Quaternion.LookRotation(desiredDirection);
    }

    // Animator event
    private void OnAnimatorMove()
    {
        rb.MovePosition(rb.position + moveDirection * animator.deltaPosition.magnitude);
        rb.MoveRotation(rotation);
    }








}