using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]  private Animator anim;
    private float damage;
    public EnemyRoam roam;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roam.isChasing) {
            jumpAttack();
            anim.SetTrigger("Bite");
            rb.AddForce(new Vector2(0,-0.5f), ForceMode2D.Impulse);
        }
    }

    public void jumpAttack() {
        rb.AddForce(new Vector2(0,0.5f), ForceMode2D.Impulse);
    }
}
