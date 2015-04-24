using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour {
	/*! This script allows the user to select varying levels
	 * of difficulty. Veteran players will be able to test 
	 * their abilities against enemies that spawn more quickly.
	 * 
	 */ 
	public static int difficulty; //! Difficulty will be adjusted based on a few integers 
	public Text thisText;
	public Text otherText1;
	public Text otherText2;

	void Start()
	{
		difficulty = 2;
	}

	public void Easy() //! This method changes difficulty to Easy
	{
		difficulty = 1; 
		colorChanges ();
	}

	public void Medium() //! Changes difficulty to Medium
	{
		difficulty = 2;
		colorChanges ();
	}

	public void Hard() //! Changes difficulty to Hard
	{
		difficulty = 3;
		colorChanges ();
	}

	void colorChanges() //! This method handles any color changes the user wishes to impose.
	{
		thisText.color = Color.yellow;
		otherText1.color = Color.white;
		otherText2.color = Color.white;
	}
}
