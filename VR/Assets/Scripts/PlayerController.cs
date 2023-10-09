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
        bool isTurningLeft = animator.GetBool("isTurningLeft");
        bool leftTurnPressed = Input.GetKey("a");
        bool isJumping = animator.GetBool("isJumping");
        bool JumpPressed = Input.GetKey("space");
        bool isWalkingBack = animator.GetBool("isWalkingBack");
        bool WalkBackPressed = Input.GetKey("s");
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
        if (rightTurnPressed && !isTurningRight)
        {
            animator.SetBool("isTurningRight", true);
        }
        //StopTurningRight
        if (!rightTurnPressed && isTurningRight)
        {
            animator.SetBool("isTurningRight", false);
        }
        //StopRunning & StartTurningRight
        if (rightTurnPressed && !isTurningRight && isRunning && !forwardPressed)
        {
            animator.SetBool("isTurningRight", true);
            animator.SetBool("isRunning", true);
        }

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
        //StopRunning & StartTurningLeft
        if (leftTurnPressed && !isTurningLeft && isRunning && !forwardPressed)
        {
            animator.SetBool("isTurningLeft", true);
            animator.SetBool("isRunning", true);
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
        //StopRunning & StartJumping
        if (!isJumping && JumpPressed && isRunning && !forwardPressed)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", true);
        }
    }

}
