using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilities : MonoBehaviour
{

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("fireball");

            GameObject fireball = Instantiate(projectile, transform.position, transform.rotation);
            
            fireball.SetActive(true);
            fireball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up);

        }
    }
}

