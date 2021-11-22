using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragthree : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject dropPlace_GO;
    private Vector3 dropPlacePosition;
    private bool isCorrectPlace = false;
    private bool locked = false;
    // Start is called before the first frame update
    void Start()
    {
        dropPlacePosition = dropPlace_GO.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

    }
    void OnMouseUp()
    {
        if (isCorrectPlace == true)
        {
            this.gameObject.transform.position = dropPlacePosition;
            locked = true;
        }
        else
        {
            this.gameObject.transform.position = startPosition;
        }
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
        if (other.gameObject.name == "last")
        {
            Debug.Log("the drag item get inside the drop place");
            isCorrectPlace = true;
        }
    }
}