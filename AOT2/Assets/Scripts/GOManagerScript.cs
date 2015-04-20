using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GOManagerScript : MonoBehaviour {
	public Text scoreText;
	
	void Start()
	{
		scoreText.text = "Score: " + ManagerScrip.totScoreInt;
	}
}
