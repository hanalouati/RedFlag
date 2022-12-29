using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy_Wall : MonoBehaviour 
{

    [SerializeField]
    GameObject objectToDestroy;

    public void DestroyGameObject()
    {
       Destroy (objectToDestroy);
    }
}
