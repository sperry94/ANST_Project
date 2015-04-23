using UnityEngine;
using System.Collections;

/**
 * Script that handles Square object spawning and Setting Camera.
 * Changes number of squares spawned based off of chosen difficulty and 
 * Camera perspective based off of chosen handedness.
 */
public class squareSpawnScript : MonoBehaviour
{
	/**
	 * The prefab for the Square object.
	 */
	public GameObject squares;
	/**
	 * The number of squares to be spawned.
	 */
	public int numsquares;
	/**
	 * The camera to be used for the right hand selection.
	 */
	public Camera RH;
	/**
	 * The camera to be used for the left hand selection
	 */
	public Camera LH;

	public GameObject[] ActiveSquares;

	/**
	 * Function run upon initiating game.
	 * Sets number of squares spawned based on difficulty and camera perspective
	 * based on handedness. Squares are uniformly spawned accross bottom of screen.
	 */
	void Start() 
	{

		if (DifficultyScript.difficulty == 1) {
			numsquares = 8;
		} else if (DifficultyScript.difficulty == 3) {
			numsquares = 3;
		} else {
			numsquares = 5;
		}
		if (handScript.hand == 1) {
			LH.enabled = true;
			RH.enabled = false;
		} else {
			LH.enabled = false;
			RH.enabled = true;
		}
		float mid = transform.position.y;
		float left = transform.position.x;
		float right = transform.position.x+GetComponent<Renderer>().bounds.size.x;
		float spacing = (right - left) / numsquares;

		for (int i = 0; i< numsquares; i++)
		{
			Vector2 spawnp = new Vector2((left+i*spacing),mid);
			Instantiate (squares, spawnp, Quaternion.identity);
		}
	}

	void Update()
	{
		ActiveSquares = GameObject.FindGameObjectsWithTag ("Square");
		if (ActiveSquares.Length == 0) {
			Application.LoadLevel(2);
		}
	}

	/**
	 * Function run when a collision is detected with collider at bottom of screen.
	 * If a triangle collides with the collider at the bottom of the screen, the game
	 * is ended and the game over screen is loaded.
	 * @param obj the object that collided with the collider at the bottom of the screen.
	 */
	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Application.LoadLevel(2);
		}
	}

}
