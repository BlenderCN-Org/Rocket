using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableScript : MonoBehaviour
{

    public GameObject ScoreText;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (ScoreText == null)
            ScoreText = GameObject.FindGameObjectWithTag("Score");

        text = ScoreText.GetComponent<Text>();
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
        }

        string prevScore = text.text.ToString();
        int score = Convert.ToInt32(prevScore);
        score++;
        text.text = Convert.ToString( score);

    }
}
