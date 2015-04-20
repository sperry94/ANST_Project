using UnityEngine;
using System.Collections;

public class spawnerScript : MonoBehaviour 
{

	public float spawnt = 1;
	public GameObject Triangle;


	void Start () 
	{
		InvokeRepeating ("newTriangle", spawnt, spawnt);
	}

	void newTriangle()
	{
		float left = transform.position.x;
		float right = transform.position.x+GetComponent<Renderer>().bounds.size.x;
		Vector2 spawnp = new Vector2(Random.Range(left,right),transform.position.y);
		Instantiate (Triangle, spawnp, Quaternion.identity);

	}
}
