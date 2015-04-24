using UnityEngine;
using System.Collections;

public class shooterScript : MonoBehaviour 
{
	/*! This script allows projectiles to be fired
	 * within the shooter bar on the left or right of
	 * the screen. Position coordinates are used to 
	 * ensure that projectiles are only able to be
	 * fired from the shooter bar.
	 */
	public GameObject Circle;

	public float shootLim;
	float lastShot;

	void Start(){
		lastShot=0;
		shootLim = 0.8f; //! Limit the speed that projectiles can be shot.
	}
	
	void Update () {
		if ((Time.time - lastShot) >= shootLim) {
			GetComponent<SpriteRenderer>().color = Color.white;
		}
		Vector2 lim = transform.position+GetComponent<Renderer>().bounds.size;
		Vector2 spawnp = new Vector2();
		if (Input.GetKeyDown (KeyCode.Mouse0)) //! If user clicks mouse in the bounded area, fire projectiles. 
		{
			spawnp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			bool height = spawnp.y>=transform.position.y && spawnp.y<=lim.y; //! x and y coordinates are used to ensure projectiles can only be fired from the bar.

			bool width = spawnp.x>=transform.position.x && spawnp.x<=lim.x;

			if(height && width && (Time.time - lastShot)>=shootLim) //! Ensure that the rate of fire is limited.
			{
				Instantiate (Circle, spawnp, Quaternion.identity);
				lastShot = Time.time;
				GetComponent<SpriteRenderer>().color = Color.red;
			}
		}

	}
}
