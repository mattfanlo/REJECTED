using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.tag != "Weapon")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
