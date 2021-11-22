using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentmove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float dirX, moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX= Input.GetAxis("Horizontal") * moveSpeed;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y); 
    }
}
