using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag2 : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject dropPlace;
    private Vector3 dropPlaceP;
    private bool isCorrectPlace = false;
    private bool locked = false;
    // Start is called before the first frame update
    void Start()
    {
        dropPlaceP= dropPlace.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseUp()
    {
        if (isCorrectPlace == true)
        {
            this.gameObject.transform.position = dropPlaceP;
            locked = true;
        }
        else
        {
            this.gameObject.transform.position = startPosition;
        }
    }
    void OnMouseDown()
    {
        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

    }
    void OnMouseDrag()
    {
        if (locked == true)
        {
            Debug.Log("can drag anymore");
        }
        else
        {
            Debug.Log("can drag");
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            this.transform.position = curPosition;
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "answer")
        {
            Debug.Log("the drag item get inside the drop place");
            isCorrectPlace = true;
        }
       
    }
}
