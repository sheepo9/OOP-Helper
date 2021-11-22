using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* this is a class that is used to control the behaviour level 2 scene  */

public class Level2ViewModel : MonoBehaviour
{
// type Text variable 
    public Text CurrentQuestionText;
    public Text CheckAnswers;
    public Text getanswer;
    public Text CheckAnswer;
    public Text ScoreText;

    public string CurrentAnswerValue; // string value to hold the correct answer
    public List<Level2Model> questions; // a list that stores the question

    // variable of int type 
    public int CurrentQuestionNumber;
    public int score;
    public int TotalQuestions;

    public Button btnClick;
    public InputField inputuser;
     // game objects used to control the panel in the level 2 scene
    public GameObject RightPanel;
    public GameObject WrongPanel;
    public GameObject FinishPanel;

    // Start is called before the first frame update
    void Start()
    {
        TotalQuestions = questions.Count;
        CurrentQuestionNumber = 1;
        score = 0;
        LoadQuestion();
        btnClick.onClick.AddListener(GetInputOnClick);
        // deactivating all panel  so that only one is open 
        RightPanel.SetActive(false);
        WrongPanel.SetActive(false);
        FinishPanel.SetActive(false);
    }
    // method to load the next scene according to the given name 
    public void LoadScene3(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    // the method that provides the function to restart the  Level 

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToStart(string scenename)
    {
        SceneManager.LoadScene(scenename);


    }
    /* this is the method used to check if the user provided by the user is the same as the notes in the List*/
    public void Verify()
    {
        
        if (CurrentAnswerValue.Equals(inputuser.text))
        {
            score++;
            
            ScoreText.text = score + "/" + TotalQuestions;
           RightPanel.SetActive(true);
        }
        else
        {
            WrongPanel.SetActive(true);
        Debug.Log("wrong");

         }



    }
    // method to load the next questioin from the list
    public void NextQuestion()
    {
        RightPanel.SetActive(false);
        WrongPanel.SetActive(false);
        if (CurrentQuestionNumber < TotalQuestions)
        {
            CurrentQuestionNumber++;
            LoadQuestion();
        }
        else
        {
            Debug.Log(" Completed");
            FinishPanel.SetActive(true);
        }
    
    }
    // the method that randomly generates the question
    private void LoadQuestion()
    {
        var index = Random.Range(0, questions.Count);
        CurrentQuestionText.text = questions[index].QuestionText;
        CurrentAnswerValue = questions[index].Answer;
        questions.RemoveAt(index);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetInputOnClick()
    {
        Debug.Log(" INPUT" + inputuser.text);
    }

}
