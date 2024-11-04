using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    public Text losetext;
    private Animator anim;

    public Rigidbody2D playerRB;
    public float KBForce;
    public float KBCounter;
    public float KBTotal;
    public bool KnockFromRight;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            
        }


    }

    private void FixedUpdate()
    {
        if (KBCounter <= 0)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
        else {
            if (KnockFromRight) {
                playerRB.velocity = new Vector2(-KBForce, KBForce);
            }
            if (!KnockFromRight) {
                playerRB.velocity = new Vector2(KBForce, KBForce);
            }

            KBCounter -= Time.deltaTime;
        }
        
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Lose") {
            PauseMenu.isPaused = true;
            losetext.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
