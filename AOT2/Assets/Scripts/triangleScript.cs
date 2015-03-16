using UnityEngine;
using System.Collections;

public class triangleScript : MonoBehaviour {

	void Start () {

		Vector2 speed = GetComponent<Rigidbody2D>().velocity;

		speed.y = -5;

		GetComponent<Rigidbody2D> ().velocity = speed;

		Destroy (gameObject,3);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
