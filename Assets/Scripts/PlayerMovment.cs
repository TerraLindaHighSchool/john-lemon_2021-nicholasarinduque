using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rd;
    private Vector3 moveDirection;
    private Quaternion rotaion;
    private bool isWalking;

    [SerializeField] private float turnSpeed = 20f; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rotaion = Quaternion.identity;
    }

    // Update is called once per frame

    //Get user input to set direction player will move
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    //Set animatorto walking or idle depending on user input
    isWalking = !(Mathf.Approximately(horizontal, 0f) && Mathf.Approximaly(vertical, 0f)
    //Assign rotation towards move direction 
    void FixedUpdate()
    {

    }

    private void OnAnimatorMove()
    {

    }

}