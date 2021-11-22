using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    private int nextSceneToLoad;
    
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1; ;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
