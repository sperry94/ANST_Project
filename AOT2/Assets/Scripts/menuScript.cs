using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * This script handles menu behaviors.
 */
public class menuScript : MonoBehaviour {

	public static string username;

	public Text uname;

	/**
 	 * This function loads the main game.
 	 */
	public void Loader()
	{
		Application.LoadLevel(1);
	}
	
	/**
 	 * This function quits the game.
 	 */
	public void Quitter()
	{
		Application.Quit();
	}
	
	/**
 	 * This function loads the mainMenu
 	 */
	public void mainMenu()
	{
		Application.LoadLevel (0);
	}

	public void PlayAgain()
	{
		Application.LoadLevel (1);
	}

	public void setName()
	{
		username = uname.text;
	}

	public void Credits()
	{
		Application.LoadLevel (3);
	}
}
