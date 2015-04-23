using UnityEngine;
using System.Collections;

public class spawnerScript : MonoBehaviour 
{
	/*! This script spawns instances of the enemy triangles so
	 * that the user can shoot the triangles to defend the 
	 * squares below.
	 */

	public float spawnt = 1; //! Controls rate at which triangles spawn.
	public GameObject Triangle; 


	void Start () 
	{
		InvokeRepeating ("newTriangle", spawnt, spawnt); //! Triangle game objects will spawn repeatedly.
	}

	void newTriangle() //! The following method controls where the triangles spawn.
	{
		float left = transform.position.x;
		float right = transform.position.x+GetComponent<Renderer>().bounds.size.x;
		Vector2 spawnp = new Vector2(Random.Range(left,right),transform.position.y);
		Instantiate (Triangle, spawnp, Quaternion.identity); //! Spawn many instances of enemy triangles.

	}
}
