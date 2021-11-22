using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introductionViewModel : MonoBehaviour
{    public List<Questions> questions;
    public Text CurrentQuestionText;
    private bool CurrentAnswerValue;
    public int TotalQuestions;
    public int CurrentQuestionNumber;
    private int score;
    public Text ScoreText;

    public GameObject QuizPanel;
    public GameObject GoPanel;
    // Start is called before the first frame update
   public void Start()
    {
        GoPanel.SetActive(false);
        LoadQuestion();
        TotalQuestions = questions.Count;
        CurrentQuestionNumber = 0;
        score = 0;
    }
   public void Gameover()
   {
       GoPanel.SetActive(false);
       QuizPanel.SetActive(false);
       ScoreText.text = score + "/" + TotalQuestions;
   }
    public void AnsweredTrue()
    { if (CurrentAnswerValue == true) score++;

                // load next question or results page
    if (CurrentQuestionNumber < TotalQuestions)
    {
        // increase question counter
        CurrentQuestionNumber++;
        LoadQuestion();
    }
    else
    {
       // Gameover();
        GoPanel.SetActive(true);
        ScoreText.text = score + "/" + TotalQuestions;
    }
    }
    public void AnsweredTFalse()
    {
        if (CurrentAnswerValue == false) score++;

        // load next question or results page
        if (CurrentQuestionNumber < TotalQuestions)
        {
            // increase question counter
            CurrentQuestionNumber++;
            LoadQuestion();
        }
        else
        {
            GoPanel.SetActive(true);
            ScoreText.text = score + "/" + TotalQuestions;
         }
    }
    private void LoadQuestion()
    {
        var index = Random.Range(0, questions.Count);
        CurrentQuestionText.text = questions[index].Question;
        CurrentAnswerValue = questions[index].Answer;
        questions.RemoveAt(index);
    }
    public void LoadScene0(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
