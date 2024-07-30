using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Square : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public float movelimiter = 0.7f;

    public float Walk_Speed = 5.0f;

  
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= movelimiter;
            vertical *= movelimiter;
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * Walk_Speed, vertical * Walk_Speed);
    }

}

