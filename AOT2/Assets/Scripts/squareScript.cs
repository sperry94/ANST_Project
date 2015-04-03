using UnityEngine;
using System.Collections;

public class squareScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.gameObject.name == "Triangle(Clone)") {
			Destroy (obj.gameObject);
			Destroy (gameObject);
		} 
		else {
			Destroy (obj.gameObject);
		}
	}
}
