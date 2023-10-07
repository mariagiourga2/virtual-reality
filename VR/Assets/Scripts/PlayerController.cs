using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("standing");
            playerAnim.SetBool("walking", false);
            playerAnim.SetBool("turnRight", false);
            playerAnim.SetBool("turnLeft", false);
            playerAnim.SetBool("jump", false);
            playerAnim.SetBool("looking", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("walking");
            playerAnim.SetBool("walking", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("Turn Right");
            playerAnim.SetBool("turnRight", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Turn Left");
            playerAnim.SetBool("turnLeft", true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Jump");
            playerAnim.SetBool("jump", true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Looking");
            playerAnim.SetBool("looking", true);
        }
    }
}
