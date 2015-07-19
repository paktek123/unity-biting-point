using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	//public GameObject scoreTextObject;
	private Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {

		score = 0;
		GameObject scoreTextObject = GameObject.FindWithTag ("ScoreText");
		scoreText = scoreTextObject.GetComponent<Text>();
		UpdateScore ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
}
