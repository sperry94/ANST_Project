using UnityEngine;
using System.Collections;

public class shooterScript : MonoBehaviour {

	public GameObject Circle;

	public float shootLim;
	float lastShot;

	void Start(){
		lastShot=0;
		shootLim = 0.7f;
	}
	
	void Update () {
	
		Vector2 lim = transform.position+GetComponent<Renderer>().bounds.size;
		Vector2 spawnp = new Vector2();
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			spawnp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bool height = spawnp.y>=transform.position.y && spawnp.y<=lim.y;
			bool width = spawnp.x>=transform.position.x && spawnp.x<=lim.x;
			if(height && width && (Time.time - lastShot)>=shootLim){
				Instantiate (Circle, spawnp, Quaternion.identity);
				lastShot = Time.time;
			}
		}

	}
}
