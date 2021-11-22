using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level4ViewModel : MonoBehaviour
{
    // Start is called before the first frame update
 public GameObject[] options;
    public int currentQuestion;
    public List<Questions> questions;
    public Text QuestionText;
   public GameObject QuizPanel;
    //public GameObject GoPanel;
    //public Text ScoreText;
    int totalQuestions = 0;
    public int score;

    public void Start()
    {
        QuizPanel.SetActive(true);
          // GoPanel.SetActive(false);
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
        //GoPanel.SetActive(true);
        QuizPanel.SetActive(false);
       // ScoreText.text = score + "/" + totalQuestions;
    }
    public void wrong()
    {
        if (questions.Count > 0)
        {
            questions.RemoveAt(currentQuestion);
            generateQuestion();
        }
        else
        {
            Debug.Log(" Tall Done");
            Gameover();
        }
    }
    public void Correct()
    { if(questions.Count >0)
    {
        score +=1;
        generateQuestion();
        questions.RemoveAt(currentQuestion);
    }
    else
    {
        Debug.Log("Done");
        Gameover();
    }
    }
    void generateQuestion()
    { if(questions.Count >0)
    {

        currentQuestion = Random.Range(0, questions.Count);
        QuestionText.text = questions[currentQuestion].Question;
        SetAnswers();
    }
    else
    {
        Debug.Log("Out of Questions ");
        Gameover();
    }
    }
    void SetAnswers()
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
}
