using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float move = 10f;
    public float jumpForce = 50f;
    
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
        if(Input.GetKeyDown (KeyCode.W)){
            rb.velocity = transform.up * jumpForce;
        }
        else if(Input.GetKey (KeyCode.A)){
            transform.Translate(Vector2.left * (Time.deltaTime * move), Space.Self);
        }
        else if(Input.GetKey (KeyCode.D)){
            transform.Translate(Vector2.right * (Time.deltaTime * move), Space.Self);
        }
        else{
            transform.Translate(Vector2.zero, Space.Self);
        }
    }
}
