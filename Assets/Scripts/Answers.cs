using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using Serialization;

public class Answers : MonoBehaviour
{
    public bool IsCorrect = false;
    public QuizGame quiz;
    public void Answer()
    {
    if (IsCorrect)
    {
        Debug.Log("Correct Answer");
        quiz.Correct();
    }
    else{
    Debug.Log(" Wrong Answer");
    quiz.wrong();
    }

    }
}
