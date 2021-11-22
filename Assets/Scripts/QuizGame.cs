using System.Collections;
using System.Collections.Generic;using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizGame : MonoBehaviour
{/* this cclass controls all the multiple choice questions quizzes of the game*/
    
    public GameObject[] options;
    public int currentQuestion;
    public List<Questions> questions;
    public Text QuestionText;
    public GameObject QuizPanel;
    public GameObject GoPanel;
    public Text ScoreText;
    int totalQuestions = 0;
    public int score;
    public void Start()
    {        
        GoPanel.SetActive(false);
        generateQuestion();
        totalQuestions = questions.Count;
    
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToStart(string scenename)
    {
        SceneManager.LoadScene(scenename);


    }
   
    public void NextLevel(string scenename)
    {
        SceneManager.LoadScene(scenename);

    
    }
    public void Gameover()
    {
        GoPanel.SetActive(true);
        QuizPanel.SetActive(false);
        ScoreText.text = score + "/" + totalQuestions;
    }
    // a method that checks if the answer is wrong
    public void wrong()
    {
        //try
        //{
            if (questions.Count > 0)
            {
                generateQuestion();
                questions.RemoveAt(currentQuestion);
               
            }
        //}
       // catch( Exception E)
            else {
            Debug.Log(" Tall Done");
            Gameover();
        }
    }
    // a method that checks if the answer is correct 
    public void Correct()
    {
       // try { 
        if(questions.Count >0)
    {
        score +=1;
        generateQuestion();
        questions.RemoveAt(currentQuestion);
    }
        //}
       // catch(Exception e)
        else  {
        Debug.Log("Done");
        Gameover();
    }
    }
    // the method that randomly generates the question
    void generateQuestion()
    { 

        try         {
            if(questions.Count >0)
    
            {
        currentQuestion = UnityEngine.Random.Range(0, questions.Count);
        QuestionText.text = questions[currentQuestion].Question;
        SetAnswers();
        }}
           catch (Exception e)
         {
        Debug.Log("Out of Questions ");
        Gameover();
    }
    }
    // a method to load the answer options
    void SetAnswers()
    {
        try
        {
            for (int i = 0; i < options.Length; i++)
            {
                options[i].GetComponent<Answers>().IsCorrect = false;
                options[i].transform.GetChild(0).GetComponent<Text>().text = questions[currentQuestion].Answers[i];

                if (questions[currentQuestion].CorrectAnswer == i + 1)
                {
                    options[i].GetComponent<Answers>().IsCorrect = true;
                }
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Debug.Log("Out of Questions ");
        }
        catch (Exception e)
        {
            Debug.Log(" An error occured");
        }
    }
}
