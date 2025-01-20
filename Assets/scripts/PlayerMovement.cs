using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;// a public reference to rigidbody component for this object
    public float ForceZ=950f,ForceY=-200f,ForceX=200f,jumpForce=10f;
    void Start()//start function is not needed in every script but only at the starting script of the game 
    {
        Debug.Log("scene is working");
        
    }

    void FixedUpdate()// when dealing with physics use FixedUpdate instead of update function for better performance 
    {
        // Time.deltaTime ensures proper frame rate on all types of devices
        rb.AddForce(0,ForceY* Time.deltaTime , ForceZ* Time.deltaTime);
        if(Input.GetKey("d")){
            
            rb.AddForce(ForceX*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-ForceX*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("space")){
            rb.AddForce(0,jumpForce*Time.deltaTime,0,ForceMode.Impulse);
        }
        if(rb.position.y < 5.0){
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
