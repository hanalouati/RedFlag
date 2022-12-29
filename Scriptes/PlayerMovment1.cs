using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float jumpAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 5;
            sr.flipX = false;
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 5;
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp("d") ||  Input.GetKeyUp("q") ||  Input.GetKey("z"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}