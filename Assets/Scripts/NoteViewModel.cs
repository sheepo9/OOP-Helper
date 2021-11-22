using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NoteViewModel : MonoBehaviour
{
    public List<NotesModel> notes;

    public Text NoteText;
    public Text TextTitle;
    int currentNoteNumber;
    public GameObject QuizPanel;
    public GameObject FinishPanel;
    public GameObject back;
    int totalquestions;
    // Start is called before the first frame update
    void Start()
    {// deactivating the finish and back panel upon loading the quiz panel
        FinishPanel.SetActive(false);
        QuizPanel.SetActive(true);
        back.SetActive(false);
        // initializing the variables 
        currentNoteNumber = 0;
        totalquestions = notes.Count;

         LoadNote(0); // loading the first note
    }
    // method to load the notes from the lists
    public void LoadNote(int index)
    {
        NoteText.text = notes[index].NoteText;
       TextTitle.text = notes[index].Title;
    }
    // a method that traverse through the notes
    public void NextNote() {
        try
        {
            if (currentNoteNumber < totalquestions)
            {
                currentNoteNumber++;
                LoadNote(currentNoteNumber);
            }
        }
        catch (Exception e)
        {
          
            FinishPanel.SetActive(true);

        }
       
    }
    // the method that all users to go backwards
    public void PreviousNote()
    {
        try
        {
            if (currentNoteNumber < totalquestions)
            {
                currentNoteNumber--;
                LoadNote(currentNoteNumber);
            }
        }
        catch (Exception e)
        {

            back.SetActive(true);

        }

    }
     // loading the scenes according to the given scene name
    public void LoadScene0(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
