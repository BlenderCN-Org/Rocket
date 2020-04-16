using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ParticleSystem explosion;

    private GameObject ScoreText;
    private ScoreUpdater scoreUpdater;
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
        if (other.gameObject.tag == "Enemy")
        {
            scoreUpdater.AddScore();
            Destroy(other.gameObject);
        }

        Destroy(gameObject);

        if (explosion != null)
            Instantiate(explosion, transform.position, transform.rotation);
     
    }
}
