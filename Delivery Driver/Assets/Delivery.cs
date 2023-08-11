using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delayDestory = 1f;
    [SerializeField] Color32 packageColour = new Color32(255,0,0,255);
    [SerializeField] Color32 noPackageColour = new Color32(255,255,255,0);

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColour;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {

    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package picked up");
            Destroy(other.gameObject, delayDestory);
            spriteRenderer.color = packageColour;
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColour;
        }
    }
}
