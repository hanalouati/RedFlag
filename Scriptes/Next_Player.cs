using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Player : MonoBehaviour
{
    private int Level5;

    private void Player()
    {
        Level5 = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
        SceneManager.LoadScene("Level5");
        }
    }
}
