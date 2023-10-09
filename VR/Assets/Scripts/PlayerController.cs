using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
        

    private void Awake()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool forwardPressed = Input.GetKey("w");

        bool isTurningRight = animator.GetBool("isTurningRight");
        bool rightTurnPressed = Input.GetKey("d");

        bool isJumping = animator.GetBool("isJumping");
        bool JumpPressed = Input.GetKey("space");
        //StartRunning
        if (!isRunning && forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }
        //StopRunning
        if (isRunning && !forwardPressed)
        {
            animator.SetBool("isRunning", false);
        }        
        //StartTurningRight
        if(rightTurnPressed && !isTurningRight)
        {
            animator.SetBool("isTurningRight", true);
        }
        //StopTurningRight
        if (!rightTurnPressed && isTurningRight)
        {
            animator.SetBool("isTurningRight", false);
        }
        //StartJumping
        if (!isJumping && JumpPressed)
        {
            animator.SetBool("isJumping", true);
        }
        //StopJumping
        if (isJumping && !JumpPressed)
        {
            animator.SetBool("isJumping", false);
        }
        //StartJumping & StopRunning
        if (!isJumping && JumpPressed && isRunning && !forwardPressed)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", false);

        }
        //StopJumping & StartRunning
        if (isJumping && !JumpPressed && !isRunning && forwardPressed)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", true);
        }
    }

}
