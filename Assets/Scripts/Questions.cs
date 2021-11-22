using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Questions 
{/* a model class for all multiple choice */ 
    [TextArea]
    public string Question;
    public string[] Answers;
    public int CorrectAnswer;
    public bool Answer;
   


}
