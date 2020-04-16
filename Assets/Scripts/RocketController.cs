using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RocketController : MonoBehaviour
{

    [SerializeField]
    float acceleration = 10f;

    [SerializeField]
    float maxVelocity;

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float bulletSpeed = 500;

    void Start()
    {

    }

    // movement fields
    private Vector3 velocity = Vector3.zero;

    // shooting fields
    float timeSinceLastShot = 10f;
    bool isReloaded = false;
    public float shootSpeed = 1f;

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

        if (Input.GetKey(KeyCode.S))
        {
            velocity = Vector3.ClampMagnitude(velocity, maxVelocity);
            velocity += transform.up * acceleration * Time.deltaTime;
            transform.position += velocity;
            Debug.Log("Sapce");
        }

        // Timer
        if (isReloaded)
        {
            if (timeSinceLastShot < shootSpeed)
            {
                timeSinceLastShot += Time.deltaTime;
            }
            else
            {
                timeSinceLastShot = shootSpeed;
                isReloaded = false;
            }
        }

        // Shoot
        if (Input.GetKey(KeyCode.Space) && timeSinceLastShot >= shootSpeed)
        {
            GameObject bulletPrefab = Instantiate(Bullet, transform.position, transform.rotation);
            bulletPrefab.GetComponent<Rigidbody>().AddForce(transform.up * bulletSpeed, ForceMode.VelocityChange);
            isReloaded = true;
            timeSinceLastShot = 0f;
        }
    }
}
