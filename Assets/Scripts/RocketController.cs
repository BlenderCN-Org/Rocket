using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RocketController : MonoBehaviour
{

    [SerializeField]
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    float acceleration = 10f;

    [SerializeField]
    float maxVelocity;

    void Start()
    {
      
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-130 * Time.deltaTime, 0, 0));
            Debug.Log("Up");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(130 * Time.deltaTime, 0, 0));
            Debug.Log("Down");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -130 * Time.deltaTime));
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 130 * Time.deltaTime));
            Debug.Log("Right");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            velocity = Vector3.ClampMagnitude(velocity, maxVelocity);
            velocity += transform.up * acceleration * Time.deltaTime;        
            transform.position += velocity;
            Debug.Log("Sapce");
        }
    }
}
