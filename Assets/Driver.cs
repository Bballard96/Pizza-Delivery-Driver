using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 200; // 1
    [SerializeField] float moveSpeed = 20f ; // 0.01f
    [SerializeField] float slowSpeed = 15f;
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

}
