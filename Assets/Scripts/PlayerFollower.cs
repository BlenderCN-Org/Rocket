using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform mTarget;
    public float mSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mTarget.position);
        transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
    }
}
