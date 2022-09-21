using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveForce = 10f;
    
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();        
    }

    void Move(){
        if(Input.GetKeyDown (KeyCode.W))
        {
            rb.AddForce(Vector2.up * moveForce);
        }
        
        if(Input.GetKeyDown (KeyCode.D))
        {
            rb.AddForce(Vector2.right * moveForce);
        }

        if(Input.GetKeyDown (KeyCode.S))
        {
            rb.AddForce(Vector2.down * moveForce);
        }
        
        if(Input.GetKeyDown (KeyCode.A))
        {
            rb.AddForce(Vector2.left * moveForce);
        }
    }
}
