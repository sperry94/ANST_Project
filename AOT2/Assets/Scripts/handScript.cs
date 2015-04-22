using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class handScript : MonoBehaviour {
	public static int hand;
	public Text thisText;
	public Text otherText;
	
	void Start()
	{
		hand = 2;
	}
	
	public void LH()
	{
		hand = 1;
		colorChanges ();
	}
	
	public void RH()
	{
		hand = 2;
		colorChanges ();
	}
	
	void colorChanges()
	{
		thisText.color = Color.blue;
		otherText.color = Color.white;
	}
}
