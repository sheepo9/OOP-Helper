using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TheTimer : MonoBehaviour
{
    
    public Text  Timetext;
   public float timer ;
   public GameObject QuizPanel;
    
// update method that  dedact time until it reaches 0;  
    public void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            QuizPanel.SetActive(true);
        }
        DisplayTime(timer);
    }
    // a method to display time in minutes and seconds
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        Timetext.text = string.Format("{0:00}: {1:00}", minutes, seconds);
    }
}
