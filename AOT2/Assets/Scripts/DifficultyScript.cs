using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour {
	public static int difficulty;
	public Text thisText;
	public Text otherText1;
	public Text otherText2;

	void Start()
	{
		difficulty = 2;
	}

	public void Easy()
	{
		difficulty = 1;
		colorChanges ();
	}

	public void Medium()
	{
		difficulty = 2;
		colorChanges ();
	}

	public void Hard()
	{
		difficulty = 3;
		colorChanges ();
	}

	void colorChanges()
	{
		thisText.color = Color.blue;
		otherText1.color = Color.white;
		otherText2.color = Color.white;
	}
}
