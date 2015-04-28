using UnityEngine;
using System.Collections;

/**
 * This script is used by the Circle objects in the game.
 * This script deals with the collision detection of the Square objects.
 */
public class CircleScript : MonoBehaviour 
{
	/**
	 * The variable to store the speed of the circle.
	 */
	public Vector2 speed = new Vector2(-20,0); //! Set the speed
	/**
	 * The variable to the ManagerScript instance.
	 */
	public ManagerScript managerScript;


	/**
	 * This function runs when the script is first initialized. The function sets the speed of
	 * the circle and then gets the object that has the tag ManagerScript.
	 */
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = speed; //! Initializing velocity in terms of speed.

		GameObject managerScriptObject = GameObject.FindWithTag ("ManagerScript");

		if (managerScriptObject != null) //! If object exists.
		{
			managerScript = managerScriptObject.GetComponent <ManagerScript>(); //! 
		}
	}

	/**
	 * This function handles the collision detection of the Circle objects.
	 * This function is called when a collision with a Triangle object is detected.
	 * Handles removal of both Circle and Triangle objects and adds to the score.
	 * @param obj the object that collided with the Circle
	 */
	public void OnTriggerEnter2D(Collider2D obj) 
	{
		if(obj.gameObject.name == "Triangle(Clone)") //! If there are triangles present...
		{
			Destroy (obj.gameObject); //! Triangles must be capable of destroying our squares.
			Destroy(gameObject);
			managerScript.AddScore(5);
		}
	}

	/**
	 * This function destroys the object when it leaves the screen.
	 */
	public void OnBecameInvisible()
	{
		Destroy (gameObject); //! Triangles will destroy our gameObjects
	}
}
