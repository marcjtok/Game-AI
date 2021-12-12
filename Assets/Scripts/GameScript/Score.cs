using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score;
    public Text scoretext;
    public Text gameoverscore;
    public Text health;
    public PlayerController playerhp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoretext.text = "Score: " + score;
        gameoverscore.text = "Score: " + score;
        health.text = "Health: " + playerhp.health;
    }

    public void AddScore()
    {
        score += 10;
    }

}
