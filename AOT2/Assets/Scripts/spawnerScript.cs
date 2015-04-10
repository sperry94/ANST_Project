using UnityEngine;
using System.Collections;

public class spawnerScript : MonoBehaviour 
{

	public float spawnt = 1;
	public GameObject Triangle;
	public GUIText scoreText;

	public int score;


	void Start () 
	{
		InvokeRepeating ("newTriangle", spawnt, spawnt);
		score = 0;
		scoreText.text = "Score: 0";
	}

	void newTriangle()
	{
		float left = transform.position.x;
		float right = transform.position.x+GetComponent<Renderer>().bounds.size.x;
		Vector2 spawnp = new Vector2(Random.Range(left,right),transform.position.y);
		Instantiate (Triangle, spawnp, Quaternion.identity);

	}

	public void AddScore(int x)
	{
		score += x;
	}

	void Update () 
	{
		float totScore = score + Time.time;
		int totScoreInt = (int)totScore;
		scoreText.text = "Score: " + totScoreInt; 
	}
}
