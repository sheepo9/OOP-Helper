using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public GameObject textDisplay;
    public GameObject GoPanel;
    public GameObject QuizPanel;
    public Text ScoreText;
    public int secondsLeft = 30;
    public bool takingAway = false;

    IEnumerator Timetaker()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;
    }
        
        
        // Start is called before the first frame update
    void Start()
    {
        GoPanel.SetActive(false);
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(Timetaker());
        }
        else if(secondsLeft == 0)
        {
            GoPanel.SetActive(true);
            QuizPanel.SetActive(false);
        }
        
    }
}
