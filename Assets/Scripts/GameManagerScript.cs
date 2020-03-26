using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject gameOverCanvas;
    public GameObject MainCavas;    
    public enum GameStates { Play, GameOver};
    public GameStates gameState = GameStates.Play;
    private Health heatlhPlayer;
    void Start()
    {
        if (Player == null)
            Player = GameObject.FindGameObjectWithTag("Player");


        heatlhPlayer = Player.GetComponent<Health>();

    }


    void Update()
    {
        switch(gameState)
        {
            case GameStates.Play:
                if(!heatlhPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;                   
                }
                break;

            case GameStates.GameOver:
                gameOverCanvas.SetActive(true);
                break;
        }

    }
}
