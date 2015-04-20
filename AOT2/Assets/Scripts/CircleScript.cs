using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour 
{

	public Vector2 speed = new Vector2(-20,0);
	public ManagerScrip managerScrip;
	
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = speed;

		GameObject managerScripObject = GameObject.FindWithTag ("ManagerScrip");

		if (managerScripObject != null) 
		{
			managerScrip = managerScripObject.GetComponent <ManagerScrip>();
		}
	}

	public void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.name == "Triangle(Clone)")
		{
			Destroy (obj.gameObject);
			Destroy(gameObject);
			managerScrip.AddScore(5);
		}
	}

	public void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
