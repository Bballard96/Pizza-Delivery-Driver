using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 200; // 1
    [SerializeField] float moveSpeed = 20f ; // 0.01f
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 30f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
      float steerAmmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      float moveAmmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      transform.Rotate(0, 0, -steerAmmount);
      transform.Translate(0, moveAmmount, 0);

    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Speed Up") {
        moveSpeed = boostSpeed;
      }
      if (other.tag == "Slow Down") {
        moveSpeed = slowSpeed;
      }
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

}
