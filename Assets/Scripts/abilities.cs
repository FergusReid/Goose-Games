using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class abilities : MonoBehaviour
{

    public GameObject projectile;
    public bool mouseAim = false;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            

            GameObject fireball = Instantiate(projectile, transform.position, transform.rotation);

            Vector2 aimDir = Vector2.left;

            if (mouseAim)
            {
                Vector3 temp = Input.mousePosition;
                Vector2 mousePos = new Vector2(temp.x - Screen.width/2, temp.y - Screen.height/2);
                Vector2 playerPos = transform.position;
                aimDir = mousePos - playerPos;
                Debug.Log("fireball    " + Screen.width + "   " + mousePos.ToString());
            }
            
            fireball.SetActive(true);
            fireball.GetComponent<Rigidbody2D>().velocity = aimDir.normalized * 5;
            Destroy( fireball, 5F );
            

        }
    }
    

}

