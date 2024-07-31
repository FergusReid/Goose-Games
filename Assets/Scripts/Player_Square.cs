using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Square : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;  

    void Update()
    {
        
     //The Input is automatically assigned to WASD or Arrow Keys 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);


        
    }
    private void FixedUpdate()
    {
    //calculates diagonal movement
       rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
       
    //rotation speed
       rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

}

