using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Yo get outta the way");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {   
        if (other.tag == "Package")
        {
            Debug.log("Package picked up");
        }
    }
}
