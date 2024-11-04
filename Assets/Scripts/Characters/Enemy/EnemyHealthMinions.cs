using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthMinions : MonoBehaviour
{
    public float health;
    public  float maxHealth=100;
    public EnemyHPBar healthBar;

    public void Start()
    {
        health = maxHealth;
        gameObject.SetActive(true);
        healthBar.SetHealth(health,maxHealth);
    }


    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health,maxHealth);

        if (health <= 0)
        {
            gameObject.SetActive(false);
            Debug.Log("Enemy Died");
        }
    }

}
