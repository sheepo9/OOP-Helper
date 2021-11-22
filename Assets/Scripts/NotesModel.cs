using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class NotesModel
{ /* this is a class that is a model for the notes,
   * it used to create objects that used to stored the notes in the list
   */
    // declared variables for the notes model
    [TextArea]
    public string NoteText;
    public string Title;
    public Image pic;
}
