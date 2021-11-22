using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basics : MonoBehaviour
{
    public List<NotesModel> notes;
    public Image Pic;
    public Text TextTitle;
    int currentNoteNumber;
    int totalquestions;
    // Start is called before the first frame update
    void Start()
    {
        currentNoteNumber = 0;
        totalquestions = notes.Count;
    }

    public void LoadNote(int index)
    {
            TextTitle.text = notes[index].Title;
            Pic = notes[index].pic;
    }
    public void NextNote()
    {
        if (currentNoteNumber < totalquestions)
        {
            currentNoteNumber++;
            LoadNote(currentNoteNumber);
        }
        else
        {
            Debug.Log("End of Quiz");
            //FinishPanel.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
