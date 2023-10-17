using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;


    public float open = 100f;
    public float range = 10f;

    public GameObject door;
    public bool isOpening = false;
    public Camera fpsCam;

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
        //StartRunningForward
        if (!isRunning && forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }
        //StopRunningForward
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
        //StopRunningForward & StartTurningRight
        if (rightTurnPressed && !isTurningRight && isRunning && !forwardPressed)
        {
            animator.SetBool("isTurningRight", true);
            animator.SetBool("isRunning", true);
        }
        //StartRunningForward & StopTurningRight
        if (!rightTurnPressed && isTurningRight && !isRunning && forwardPressed)
        {
            animator.SetBool("isTurningRight", false);
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
        //StopRunningForward & StartTurningLeft
        if (leftTurnPressed && !isTurningLeft && isRunning && !forwardPressed)
        {
            animator.SetBool("isTurningLeft", true);
            animator.SetBool("isRunning", true);
        }
        //StartRunningForward & StopTurningLeft
        if (!leftTurnPressed && isTurningLeft && !isRunning && forwardPressed)
        {
            animator.SetBool("isTurningLeft", false);
            animator.SetBool("isRunning", true);
        }
        //StartTurningLeft & StopTurningRight
        if (leftTurnPressed && !isTurningLeft && !rightTurnPressed && isTurningRight)
        {
            animator.SetBool("isTurningLeft", true);
            animator.SetBool("isTurningRight", false);
        }
        //StartTurningRight & StopTurningLeft
        if (!leftTurnPressed && isTurningLeft && rightTurnPressed && !isTurningRight)
        {
            animator.SetBool("isTurningLeft", false);
            animator.SetBool("isTurningRight", true);
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
        //StartRunningForward & StartJumping
        if (!isJumping && JumpPressed && isRunning && !forwardPressed)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", true);
        }
        //StartTurningRight & StartJumping
        if (rightTurnPressed && !isTurningRight && !isJumping && JumpPressed)
        {
            animator.SetBool("isTurningRight", true);
            animator.SetBool("isJumping", true);
        }
        //StartTurningLeft & StartJumping
        if (leftTurnPressed && !isTurningLeft && !isJumping && JumpPressed)
        {
            animator.SetBool("isTurningLeft", true);
            animator.SetBool("isJumping", true);
        }
    }

}
