using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 100;
    void Start()
    {
        health = maxhealth;
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            //this.gameObject.SetActive(false);
            //Died();
        }     
    }
    public void Died(){
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
        yield return new WaitForSeconds(0.5f);
        //Died();
    }
}
