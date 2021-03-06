﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickUp : MonoBehaviour {


    private int score;
    private int load;
    private Text counterLoad;
    private Text scoreText;
	private Player1Control player;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public int Load
    {
        get
        {
            return load;
        }

        set
        {
            load = value;
        }
    }

    public Text CounterLoad
    {
        get
        {
            return counterLoad;
        }

        set
        {
            counterLoad = value;
        }
    }

    public Text ScoreText
    {
        get
        {
            return scoreText;
        }

        set
        {
            scoreText = value;
            
        }
    }

    private void Start()
    {
        scoreText = (Text)GameObject.Find("Score").GetComponent(typeof(Text));
        counterLoad = (Text)GameObject.Find("Load").GetComponent(typeof(Text));
		player =(Player1Control) GameObject.Find("Aegis_Standing_0").GetComponent(typeof(Player1Control));
    }


    void OnTriggerEnter2D(Collider2D other)
    {
		if(other.gameObject.tag == "Gold" && 1 == player.type ){
            Score++;
            Load++;
            Destroy(other.gameObject);
            updateLoad();
            updateScore();
            //Debug.Log("Coin picked up, Score = " + Score);
        }
		else if (other.gameObject.tag == "Recyclable" && 2 == player.type){
            Score++;
            Load++;
            Destroy(other.gameObject);
            updateLoad();
            updateScore();
            //Debug.Log("Recyclable picked up, Score = " + Score);
        }
		else if (other.gameObject.tag == "Residual" && 0 == player.type){
            Score++;
            Load++;
            Destroy(other.gameObject);
            updateLoad();
            updateScore();
            //Debug.Log("Residual picked up, Score = " + Score);
        }


        

    }


    public void updateLoad()
    {
        CounterLoad.text = "Load: " + Load;
    }

    void updateScore()
    {
        ScoreText.text = "Score: " + Score;
    }
}
