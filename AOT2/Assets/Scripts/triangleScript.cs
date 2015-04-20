using UnityEngine;
using System.Collections;

public class triangleScript : MonoBehaviour 
{

	public Vector2 speed;

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

	public void setSpeed(int x)
	{
		return;
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
