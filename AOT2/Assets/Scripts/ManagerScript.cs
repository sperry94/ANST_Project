using UnityEngine;
using System.Collections;

/**
 * This script manages the score count and printing during gameplay.
 */
public class ManagerScript : MonoBehaviour {

	/**
	 * The text field in which the score is printed.
	 */
	public GUIText scoreText;

	/**
	 * The variable to hold the integer score.
	 */
	int score;

	/**
	 * The variable to the total score as an integer.
	 */
	public static int totScoreInt;

	/**
	 * This function is called when the script is first enabled, initiates the variables,
	 * and prints out a placeholder for the score.
	 */
	void Start () {
		score = 0;
		totScoreInt = 0;
		scoreText.text = "Score: 0";
	}

	/**
	 * This function adds to the score value.
	 * It is called when a triangle object is destroyed by a circle object.
	 * @param x the value to increment the score by.
	 */
	public void AddScore(int x)
	{
		score += x;
	}

	/**
	 * This function is called in each frame and updates the score.
	 * The time in seconds is added to the score from destroying Triangles to give a total score.
	 */
	void Update () 
	{
		float totScore = score + Time.timeSinceLevelLoad;
		totScoreInt = DifficultyScript.difficulty*(int)totScore;
		scoreText.text = "Score: " + totScoreInt; 
	}
}
