using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level8ViewModel : MonoBehaviour
{
    // the variable of type Text
    public Text CurrentQuestionText;
    public Text CheckAnswer;
    public Text CheckAnswer1;
    public Text CheckAnswer2;

    // the variable of type string
    public string CurrentAnswerValue;
    public string CurrentAnswerValue1;
    public string CurrentAnswerValue2;

    // the variable of type int
    public int CurrentQuestionNumber;
    public int score;
    public int TotalQuestions;

    // the List that stores the question of this level 
    public List<Level8Model> questions;
    
    // the to verifies answers
    public Button btnClick;
    
    //the input fied used to get the input from the user 
    public InputField inputuser1;
   

    // the objects used to control the panels of this level
    public GameObject RightPanel1;
    public GameObject WrongPanel1;
    public GameObject FinishPanel;

    // Start is called before the first frame update
    void Start()
    {
        // initializing variables 
        TotalQuestions = questions.Count;
        CurrentQuestionNumber = 1;
        score = 0;
        LoadQuestion(); // loading the first question
       
       
        // deactivating the panels when the scene loads
        FinishPanel.SetActive(false);
        RightPanel1.SetActive(false);
        WrongPanel1.SetActive(false);
      
    }
    /* this is the method used to check if the user provided by the user is the same as the notes in the List*/
    public void Verifies()
    {
          if (!CurrentAnswerValue1.Equals(inputuser1.text)) // checking if the answer is correct
            {
                Debug.Log("wrong");
                WrongPanel1.SetActive(true);
            }
            else
            {
               
                Debug.Log("Correct");
                RightPanel1.SetActive(true);
            }
          
       
    }
    // the method that provides the function to restart the  Level 
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // method to load the next scene according to the given name 
    public void LoadScene3(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    // method to load the next questioin from the list
    public void NextQuestion()
    {
        RightPanel1.SetActive(false);
        WrongPanel1.SetActive(false);
        if (CurrentQuestionNumber < TotalQuestions)
        {
            CurrentQuestionNumber++;
            LoadQuestion();
            inputuser1.text = "";
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
        CurrentAnswerValue1 = questions[index].CurrentAnswer;
        questions.RemoveAt(index);
    }
   
  
}
