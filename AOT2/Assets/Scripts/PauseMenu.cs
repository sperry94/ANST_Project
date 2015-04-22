using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
	/*! PauseMenu script allows the Pause Interface to enable the user to access
	 * settings that may need to be changed mid-game. In addition, the player can
	 * pause to take a break during a game.
	 * 
	 */
	public GUISkin mySkin;

	private Rect windowRect;
	private bool paused = false, waited = true;

	private void Start()
	{
		windowRect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200);
	}

	private void waiting()
	{
		waited = true;
	}

	private void Update()
	{
		if (waited) //! If user hits escape or P, modify the boolean to show that the game is paused.
			if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.P)) 
			{
				if (paused)
					paused = false;
				else
					paused = true;

				waited = false;
				Invoke("waiting", 0.3f);
			}
		if (paused)  //! If user pauses, stop the time.
			Time.timeScale = 0;
		else 
			Time.timeScale = 1;
	}

	private void OnGUI()
	{
		if (paused) //! If paused create the window to provide a pause interface.
			windowRect = GUI.Window(0, windowRect, windowFunc, "Pause Menu");
	}

	private void windowFunc(int id)
	{
		if (GUILayout.Button ("Resume")) //! Resume button. If pushed, the game will no longer be paused.
		{
			paused = false;
		}
		GUILayout.BeginHorizontal (); 
		if (GUILayout.Button ("Disable Sound"))
		{

		}
		if (GUILayout.Button ("End Game")) //! End game button allows the user to end the game early.
		{
			Application.LoadLevel(2);
		}
		GUILayout.EndHorizontal ();
		if (GUILayout.Button ("Quit")) //! If Quit button is pushed, allow the user to quit the game.
		{
			Application.Quit();
		}
	}
}
