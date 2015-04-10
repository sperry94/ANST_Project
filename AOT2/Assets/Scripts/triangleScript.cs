using UnityEngine;
using System.Collections;

public class triangleScript : MonoBehaviour 
{

	public Vector2 speed;

	void Start () 
	{

		speed.y = -5;

		GetComponent<Rigidbody2D> ().velocity = speed;

	}

	public void setSpeed(int x)
	{
		return;
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
