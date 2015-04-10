using UnityEngine;
using System.Collections;

public class squareScript : MonoBehaviour
{

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy (gameObject);
		} 
		else
		{
			Destroy (obj.gameObject);
		}
	}
}
