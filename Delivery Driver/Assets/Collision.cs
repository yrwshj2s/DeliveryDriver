using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("how to change sprites completely when hit?");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("sugondese");
    }
}
