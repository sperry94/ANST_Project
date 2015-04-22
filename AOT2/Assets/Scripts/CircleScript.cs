using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour 
{

	public Vector2 speed = new Vector2(-20,0);
	public ManagerScript managerScript;
	
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = speed;

		GameObject managerScriptObject = GameObject.FindWithTag ("ManagerScript");

		if (managerScriptObject != null) 
		{
			managerScript = managerScriptObject.GetComponent <ManagerScript>();
		}
	}

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy(gameObject);
			managerScript.AddScore(5);
		}
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
