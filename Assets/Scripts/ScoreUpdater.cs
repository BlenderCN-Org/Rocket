using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public int score;

    private Text theText;

    // Start is called before the first frame update
    void Start()
    {
        theText = gameObject.GetComponent<Text>();
        score = 0;
        theText.text = Convert.ToString(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        theText.text = Convert.ToString(score);
    }
}
