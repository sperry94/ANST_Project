using UnityEngine;
using System.Collections;

public class shooterScript : MonoBehaviour {

	public GameObject Circle;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
		float mid = transform.position.y+(GetComponent<Renderer>().bounds.size.y)/2;
		Vector2 spawnp = new Vector2(transform.position.x,mid);

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (Circle, spawnp, Quaternion.identity);
		}

	}
}
