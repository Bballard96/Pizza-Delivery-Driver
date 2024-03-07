using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1;
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float steerAmmount = Input.GetAxis("Horizontal") * steerSpeed;
      float moveAmmount = Input.GetAxis("Vertical") * moveSpeed;
      transform.Rotate(0, 0, -steerAmmount);
      transform.Translate(0, moveAmmount, 0);
    }
}
