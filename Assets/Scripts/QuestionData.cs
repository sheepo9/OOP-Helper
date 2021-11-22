using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionData : MonoBehaviour

{
    [SerializeField]
    private Text wordText;
    [HideInInspector]
    public char Value;

    private Button buttonObj;
    private void Awake()
    {
        buttonObj = GetComponent<Button>();
        if (buttonObj)
        { 
            buttonObj.onClick.AddListener(() => CharSelected());
        }
    }
    public void SetChar(char value)
    {
        wordText.text = value + "";
        Value = value;
    }

    private void CharSelected()
    {
        //Level6ViewModel.instance.SelectedOption(this);
    }
}
