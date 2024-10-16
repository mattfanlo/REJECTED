using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    public void LoadScene(string sceneName) {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
    }

    public void doExitGame() { Application.Quit();
        Debug.Log("Application Quit");
        Application.Quit();
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }


}
