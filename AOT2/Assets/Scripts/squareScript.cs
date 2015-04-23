using UnityEngine;
using System.Collections;

/**
 * This script is used by the Square objects in the game.
 * This script deals with the collision detection of the Square objects.
 */
public class squareScript : MonoBehaviour
{
	/**
	 * This function handles the collision detection of the Square objects.
	 * This function is called when a collision with a Square object is detected.
	 * Handles removal of both Circle and Triangle objects, only removing the Square
	 * object when a collision with a Triangle occurs.
	 * @param obj the object that collided with the Square
	 */
	public void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy (gameObject);
		} 
		else
		{
			Destroy (obj.gameObject);
		}
	}
}
