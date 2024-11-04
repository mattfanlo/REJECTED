using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Wintext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Wintext.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
