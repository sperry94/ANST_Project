using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour 
{

	public Vector2 speed = new Vector2(-20,0); //! Set the speed
	public ManagerScript managerScript;
	
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = speed; //! Initializing velocity in terms of speed.

		GameObject managerScriptObject = GameObject.FindWithTag ("ManagerScript");

		if (managerScriptObject != null) //! If object exists.
		{
			managerScript = managerScriptObject.GetComponent <ManagerScript>(); //! 
		}
	}

	public void OnTriggerEnter2D(Collider2D obj) 
	{
		if(obj.gameObject.name == "Triangle(Clone)") //! If there are triangles present...
		{
			Destroy (obj.gameObject); //! Triangles must be capable of destroying our squares.
			Destroy(gameObject);
			managerScript.AddScore(5);
		}
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject); //! Triangles will destroy our gameObjects
	}
}
