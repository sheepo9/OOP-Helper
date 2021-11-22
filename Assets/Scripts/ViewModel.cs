using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        _totalQuestions = questions.Count;
        _currentQuestionNumber = 1;
        score = 0;
        LoadQuestion();
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<Questions> questions;

    public string _currentQuestionText;
 

    public bool _currentAnswerValue;
   
    public  int _totalQuestions;


    public int _currentQuestionNumber;
   
    
    public int score;





    public void AnsweredTrue()
    {
        Debug.Log("True button pressed");

        // check if answer is correct
        if (_currentAnswerValue == true) score++;

        // load next question or results page
        if (_currentQuestionNumber < _totalQuestions)
        {
            // increase question counter
            _currentQuestionNumber++;
            LoadQuestion();
        }
        else
        {
           
       
            Debug.Log("End of Quiz");
           
        }
    }
    public void AnsweredFalse()
    {
        Debug.Log("False button pressed");

        // check if answer is correct
        if (_currentAnswerValue == false) score++;

        // load next question or results page
        if (_currentQuestionNumber < _totalQuestions)
        {
            // increase question counter
            _currentQuestionNumber++;
            LoadQuestion();
        }
        else
        {
          
        
            Debug.Log("End of Quiz");
         
        }
    }

    private void LoadQuestion()
    {
        var index = Random.Range(0, questions.Count);
        _currentQuestionText = questions[index].Question;
        _currentAnswerValue = questions[index].Answer;
        questions.RemoveAt(index);
    }
}