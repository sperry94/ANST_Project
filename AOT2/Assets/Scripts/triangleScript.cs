﻿using UnityEngine;
using System.Collections;

public class triangleScript : MonoBehaviour {

	public Vector2 speed;

	void Start () {

		speed.y = -5;

		GetComponent<Rigidbody2D> ().velocity = speed;

		Destroy (gameObject,3);

	}

	public void setSpeed(int x)
	{
		return;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
