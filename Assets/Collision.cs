using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Yo get outta the way");
    }

    void OnTriggerEnter2D(Collision2D other) {
        Debug.Log("yes we can see you");
    }
}
