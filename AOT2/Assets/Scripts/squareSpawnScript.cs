using UnityEngine;
using System.Collections;

public class squareSpawnScript : MonoBehaviour
{

	public GameObject squares;
	public int numsquares;

	void Start () 
	{
		if (numsquares > 8) 
		{
			numsquares = 8;
		}
		else if (numsquares <= 0)
		{
			numsquares = 1;
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

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Application.LoadLevel(2);
		}
	}

}
