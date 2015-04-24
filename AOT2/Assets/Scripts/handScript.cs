using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/**
 * This script handles the handedness of the game.
 * The player can choose left handedness or right handedness.
 */
public class handScript : MonoBehaviour {

	/**
	 * The variable that stores the chosen handedness of the player.
	 */
	public static int hand;
	/**
	 * The text field that uses this instance of the script (LH or RH)
	 */
	public Text thisText;
	/**
	 * The text field that does not use this instance of the script (LH or RH)
	 */
	public Text otherText;

	/**
	 * This function is called when the script is first enabled.
	 * The default handedness(right handed) is set in this function.
	 */
	void Start()
	{
		hand = 2;
	}

	/**
	 * This function is called when LH text is clicked and sets the handedness to LH.
	 * The hand variable is set to 1(LH) and the text color is changed.
	 */
	public void LH()
	{
		hand = 1;
		colorChanges ();
	}

	/**
	 * This function is called when RH text is clicked and sets the handedness to RH.
	 * The hand variable is set to 2(RH) and the text color is changed.
	 */
	public void RH()
	{
		hand = 2;
		colorChanges ();
	}

	/**
	 * This function changes the colors of the text, blue for the selected text 
	 * and white for the other.
	 */
	void colorChanges()
	{
		thisText.color = Color.yellow;
		otherText.color = Color.white;
	}
}
