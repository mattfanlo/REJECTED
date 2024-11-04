using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoam : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public Transform[] patrolpoints;
    public float speed;
    public int patrolDestination;

    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            anim.SetBool("isChasing",true);
            if (transform.position.x > playerTransform.position.x) {
                transform.localScale = new Vector3(-2.5f, 2.5f, 1);
                transform.position += Vector3.left * speed*Time.deltaTime;
            }
            if (transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(2.5f, 2.5f, 1);
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Vector2.Distance(transform.position, playerTransform.position) > chaseDistance)
            {
                anim.SetBool("isChasing", false);
                transform.localScale = new Vector3(2.5f, 2.5f, 1);
                isChasing = false;
            }
        }
        else {
            if (Vector2.Distance(transform.position,playerTransform.position)< chaseDistance) {
                isChasing = true;
            }

            if (patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolpoints[0].position, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, patrolpoints[0].position) < 0.2)
                {
                    transform.localScale = new Vector3(-2.5f, 2.5f, 1);
                    patrolDestination = 1;
                }
            }

            if (patrolDestination == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolpoints[1].position, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, patrolpoints[1].position) < 0.2)
                {
                    transform.localScale = new Vector3(2.5f, 2.5f, 1);
                    patrolDestination = 0;
                }
            }
        }

       

    }
    
}
