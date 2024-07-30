using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
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
            fireball.GetComponent<Rigidbody2D>().velocity = Vector2.up * 5;
            Destroy( fireball, 5F );
            //CullRoutine(fireball);

        }
    }

    //private IEnumerator CullRoutine(GameObject obj)
    //{
    //    yield return new WaitForSeconds(5);
    //    obj.SetActive(false);
    //    Destroy(obj);
    //
    //}
    

}

