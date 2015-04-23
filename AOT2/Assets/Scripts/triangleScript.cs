using UnityEngine;
using System.Collections;

/**
 * Script that is used by the Triangle objects in the game.
 * The script handles the Triangle objects, particularly their
 * speeds and their destruction on exiting the screen.
 */
public class triangleScript : MonoBehaviour 
{
	/**
	 * The vector that the Triangle object's velocity will be set to.
	 */
	public Vector2 speed;

	/**
	 * Initializer for triangleScript.
	 * This is run when the script is first enabled. Speed is assigned to the
	 * Triangle objects depending on the difficulty chosen.
	 */
	void Start () 
	{
		if (DifficultyScript.difficulty == 1) {
			speed.y = -3;
		} else if (DifficultyScript.difficulty == 3) {
			speed.y = -8;
		} else {
			speed.y = -5;
		}

		GetComponent<Rigidbody2D> ().velocity = speed;

	}

	/**
 	* Function that is run when object that uses triangleScript leaves the screen.
 	* If the Triangle object exits the screen, it is destroyed.
 	*/
	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
