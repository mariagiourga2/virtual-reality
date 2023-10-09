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

        bool isTurningRight = animator.GetBool("isTurningRight");
        bool rightTurnPressed = Input.GetKey("d");
        //StartTurningRight
        if (rightTurnPressed && !isTurningRight)
        {
            animator.SetBool("isTurningRight", true);
        }
        //StopTurningRight
        if (!rightTurnPressed && isTurningRight)
        {
            animator.SetBool("isTurningRight", false);
        }

        bool isTurningLeft = animator.GetBool("isTurningLeft");
        bool leftTurnPressed = Input.GetKey("a");
        //StartTurningLeft
        if (leftTurnPressed && !isTurningLeft)
        {
            animator.SetBool("isTurningLeft", true);
        }
        //StopTurningLeft
        if (!leftTurnPressed && isTurningLeft)
        {
            animator.SetBool("isTurningLeft", false);
        }
        bool isJumping = animator.GetBool("isJumping");
        bool JumpPressed = Input.GetKey("space");
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

        bool isWalkingBack = animator.GetBool("isWalkingBack");
        bool WalkBackPressed = Input.GetKey("s");
        //StartJumping
        if (!isWalkingBack && WalkBackPressed)
        {
            animator.SetBool("isWalkingBack", true);
        }
        //StopJumping
        if (isWalkingBack && !WalkBackPressed)
        {
            animator.SetBool("isWalkingBack", false);
        }
    }

}
