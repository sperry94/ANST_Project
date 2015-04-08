using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour {

	public Vector2 speed;
	public spawnerScript spawnScript;
	
	void Start () {
	
		speed = GetComponent<Rigidbody2D>().velocity;

		speed.x = -20;
		
		GetComponent<Rigidbody2D> ().velocity = speed;

		GameObject spawnScriptObject = GameObject.FindWithTag ("spawnerScript");

		if (spawnScriptObject != null) 
		{
			spawnScript = spawnScriptObject.GetComponent <spawnerScript>();
		}
	}

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy(gameObject);
			spawnScript.AddScore(10);
		}
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
