using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/**
 * This script is used to manage the score in the game over screen.
 */
public class GOManagerScript : MonoBehaviour {

	/**
	 * The text field in which the score will be printed.
	 */
	public Text scoreText;

	/**
	 * This function is called when the script is first enabled and prints the score.
	 */
	void Start()
	{
		scoreText.text = "Score: " + ManagerScript.totScoreInt;
	}
}
