using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour {

	public Vector2 speed;

	// Use this for initialization
	void Start () {
	
		speed = GetComponent<Rigidbody2D>().velocity;

		speed.x = -10;
		
		GetComponent<Rigidbody2D> ().velocity = speed;
		
		Destroy (gameObject,5);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy(gameObject);
		}
	}
}
