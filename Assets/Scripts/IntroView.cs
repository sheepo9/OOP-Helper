using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IntroView : MonoBehaviour
{
    public Questions[] questions;
    private static List<Questions> unansweredQuestions;
    private Questions CurrentQuestion;


    [SerializeField]
    private Text QuestionText;

    [SerializeField]
    private Text trueText;

    [SerializeField]
    private Text falseText;
    [SerializeField]
    private float Delay;

    public Text ScoreText;
    public int score;
    public int current;
   public GameObject GoPanel;
    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(CurrentQuestion);
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void Start()
    {
        current = 1;
        if (unansweredQuestions == null || unansweredQuestions.Count ==0)
        {
            unansweredQuestions = questions.ToList<Questions>();

        }
        GetQuestion();
       
    }
    void GetQuestion()
    {
        int randomIndex = Random.Range(0, unansweredQuestions.Count);
        CurrentQuestion = unansweredQuestions[randomIndex];
        unansweredQuestions.RemoveAt(randomIndex);
        QuestionText.text = CurrentQuestion.Question;
        if (CurrentQuestion.Answer)
        {
            trueText.text = "Correct";
            falseText.text = "Wrong";
        }
        else {
            trueText.text = "Wrong";
            falseText.text = "Correct";
        }
    }
    public void UserSelectTrue()
    {
        if (CurrentQuestion.Answer)
        {
            score++;
            if (current <= questions.Length)
            {
                current += 1;
                Debug.Log(current);
                Debug.Log(score);
                StartCoroutine(TransitionToNextQuestion());

            }
            else
            {
                //GoPanel.SetActive(true);
                Debug.Log("wrong");
            }
        }
        StartCoroutine(TransitionToNextQuestion());
    }
   // StartCoroutine(TransitionToNextQuestion());
    // public void UserSelectFalse()
    //{
    //    if (!CurrentQuestion.Answer)
    //               score++;
        
    //if(current < questions.Length)
    //{
    //       current++;
    //    StartCoroutine(TransitionToNextQuestion());
    //}
    //else
    //{
    //    //GoPanel.SetActive(true);
    //    Debug.Log("failed");
    //}
    //StartCoroutine(TransitionToNextQuestion());
    //}

    public void UserSelectFalse()
    {
        if (!CurrentQuestion.Answer && current < questions.Length)
        {
            Debug.Log("correct");
            score+=1;
            current+=1;
            StartCoroutine(TransitionToNextQuestion());
        }
        else
        {
            //GoPanel.SetActive(true);
            Debug.Log("Help");
        }
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score + "/" + questions.Length;
    }
}
