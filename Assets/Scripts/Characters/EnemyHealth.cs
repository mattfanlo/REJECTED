using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public Text Wintext;

    public void Start()
    {
        health = 100;
        gameObject.SetActive(true);
    }



    public void TakeDamage(float damage) { 
        health -= damage;

        if (health <= 0) {
            gameObject.SetActive(false);
            Debug.Log("Enemy Died");
            Wintext.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
