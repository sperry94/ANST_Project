using UnityEngine;
using System.Collections;

/**
 * This script handles menu behaviors.
 */
public class menuScript : MonoBehaviour {

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
}
