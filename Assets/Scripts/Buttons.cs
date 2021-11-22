using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * this class is used to control the buttons on the dashboard
 * it contains methods that loads the diferent scenes
 */

public class Buttons : MonoBehaviour
{
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene0(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene1(string scenename)
    {
        SceneManager.LoadScene(scenename);

    }
    public void LoadScene2(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene3(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene4(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void LoadScene5(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
   
    public void LoadScene6(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    // a method 
    public void CloseApp() {
        Application.Quit();
    
    }
}
