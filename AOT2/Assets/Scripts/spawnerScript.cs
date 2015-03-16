using UnityEngine;
using System.Collections;

public class spawnerScript : MonoBehaviour {

	public float spawnt = 1;
	public GameObject Triangle;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("newTriangle", spawnt, spawnt);
	}

	void newTriangle()
	{
		float left = transform.position.x;
			float right = transform.position.x+GetComponent<Renderer>().bounds.size.x;
		/*float top = transform.position.y + GetComponent<Renderer>().bounds.size.y/2;
		float bottom = transform.position.x - GetComponent<Renderer>().bounds.size.y/2;*/
		Vector2 spawnp = new Vector2(Random.Range(left,right),transform.position.y);
		Instantiate (Triangle, spawnp, Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
