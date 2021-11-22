using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour
{

    private int nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1; 
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
