using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    

    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) { 
        jump = true;    
        }


    }

    private void FixedUpdate()
    {
        if (controller == null)
        {
            Debug.LogError("CharacterController2D is not assigned in the Inspector.");
            return; // Exit if controller is null
        }

        controller.Move(horizontalMove * Time.fixedDeltaTime, false , jump);
        jump = false;

    }
}
