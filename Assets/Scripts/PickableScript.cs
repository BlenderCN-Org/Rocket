using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableScript : MonoBehaviour
{

    public GameObject ScoreText;
    public ScoreUpdater scoreUpdater;

    // Start is called before the first frame update
    void Start()
    {
        if (ScoreText == null)
            ScoreText = GameObject.FindGameObjectWithTag("Score");

        scoreUpdater = ScoreText.GetComponent<ScoreUpdater>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            scoreUpdater.AddScore();
        }



    }
}
