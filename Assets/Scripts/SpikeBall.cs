using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBall : MonoBehaviour
{

    public float rotateSpeed = 300f;
    private float moveSpeed = 0.05f;

    private int MaxSteps;

    // Start is called before the first frame update
    void Start()
    {
        MaxSteps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MaxSteps++;

        if(MaxSteps > 600)
        {
            moveSpeed = -moveSpeed;
            MaxSteps = 0;
        }
        transform.position += new Vector3(moveSpeed, 0, 0);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
       
    }
}
