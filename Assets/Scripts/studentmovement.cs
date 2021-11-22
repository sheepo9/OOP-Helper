using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentmovement : MonoBehaviour
{
    Vector3 target;
    float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       SetNewTarget(new Vector3 (transform.position.x +10, transform.position.y, transform.position.z +10 ));  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetNewTarget(Vector3 newTarget)
    {
        target = newTarget;
        transform.LookAt(target);
    }
}
