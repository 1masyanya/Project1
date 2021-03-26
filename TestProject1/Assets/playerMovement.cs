using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float RunSpeed = 40f;
    
    float HorizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
    }
    
    void FixedUpdate ()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
    }
    
}
