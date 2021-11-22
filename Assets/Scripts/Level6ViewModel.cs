using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Level6ViewModel : MonoBehaviour
{
    public static Level6ViewModel instance;
    [SerializeField]
    private QuestionData[] answerWordList;     //list of answers word in the game
    [SerializeField]
    private QuestionData[] optionsWordList;

    [SerializeField]
    private Questioned questions;
    private char[] chararray = new char[12];
    public void setQuestion()
    { 
         for (int i = 0; i < questions.answer.Length; i++)
        {
            chararray[i] = questions.answer[i];
        }


         for (int j = answerWordList.Length; j < optionsWordList.Length; j++)
        {
            chararray[j]= (char)UnityEngine.Random.Range(65, 90);
        }
         chararray = ShuffleList.ShuffleListItems<char>(chararray.ToList()).ToArray(); //Randomly Shuffle the words array

         for (int k = 0; k < optionsWordList.Length; k++)
         {
             optionsWordList[k].SetChar(chararray[k]);
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        setQuestion();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class Questioned
{
    public String questionText;
    public string answer;

}