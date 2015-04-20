using UnityEngine;
using System.Collections;

public class ManagerScrip : MonoBehaviour {

	public GUIText scoreText;

	int score;

	public static int totScoreInt;

	void Start () {

		score = 0;
		totScoreInt = 0;
		scoreText.text = "Score: 0";
	}
	
	public void AddScore(int x)
	{
		score += x;
	}
	
	void Update () 
	{
		float totScore = score + Time.timeSinceLevelLoad;
		totScoreInt = (int)totScore;
		scoreText.text = "Score: " + totScoreInt; 
	}
}
