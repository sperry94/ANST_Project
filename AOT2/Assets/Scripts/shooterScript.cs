using UnityEngine;
using System.Collections;

public class shooterScript : MonoBehaviour {

	public GameObject Circle;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
		Vector2 lim = transform.position+GetComponent<Renderer>().bounds.size;
		Vector2 spawnp = new Vector2();

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			spawnp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bool height = spawnp.y>=transform.position.y && spawnp.y<=lim.y;
			bool width = spawnp.x>=transform.position.x && spawnp.x<=lim.x;
			if(height&&width){
				Instantiate (Circle, spawnp, Quaternion.identity);
			}
		}

	}
}
