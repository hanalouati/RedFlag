using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "P1")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.name == "P2")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.name == "P3")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
