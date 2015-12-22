using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text scoreText;
	public int rabbitValue;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();
	
	}
	void OnTriggerEnter2D(){
		score += rabbitValue;
		UpdateScore();
	}
	
	void UpdateScore(){
		scoreText.text = "Score:" + score;
	}
}
