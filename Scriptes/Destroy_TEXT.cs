using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy_TEXT : MonoBehaviour 
{

    [SerializeField]
    GameObject objectToDestroy;

    public void DestroyGameObject()
    {
       Destroy (objectToDestroy);
    }
}
