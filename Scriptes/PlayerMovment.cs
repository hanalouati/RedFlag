using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
        }
        if (Input.GetKeyUp("d") ||  Input.GetKeyUp("q"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
