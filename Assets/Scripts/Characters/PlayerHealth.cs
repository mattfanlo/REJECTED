using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 100;
    public Text losetext;
    void Start()
    {
        health = maxhealth;
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            losetext.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }     
    }
}
