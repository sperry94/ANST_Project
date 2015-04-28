//http://wiki.unity3d.com/index.php?title=Server_Side_Highscores

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * This script manages the server interaction.
 */
public class HSController : MonoBehaviour
{
	/**
 	 * This variable holds the secretkey designated in the server files as well.
 	 */
	private string secretKey = "AOT24LYFE"; // Edit this value and make sure it's the same as the one stored on the server
	/**
 	 * This holds the url to be used when adding a score.
 	 */
	public string addScoreURL = "http://obscure-sierra-1112.herokuapp.com/addscore.php?"; //be sure to add a ? to your url
	/**
 	 * This holds the url to be used when gettting the scores.
 	 */
	public string highscoreURL = "http://obscure-sierra-1112.herokuapp.com/display.php";


	/**
 	 * This function runs when the script is first initialized. It runs the postscores function.
 	 */
	void Start()
	{
		StartCoroutine(PostScores(menuScript.username, ManagerScript.totScoreInt));
	}


	/**
 	 * This function posts the score of the game to the database.
 	 * It then calls the get scores function to return the scores to the game
 	 * over screen high scores list
 	 * @param name the username of the player
 	 * @param score the score of the player
 	 */
	IEnumerator PostScores(string name, int score)
	{
		// remember to use StartCoroutine when calling this function!
		//This connects to a server side php script that will add the name and score to a MySQL DB.
		// Supply it with a string representing the players name and the players score.
		string hash = Md5Sum(name + score + secretKey);
		
		string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;
		
		// Post the URL to the site and create a download object to get the result.
		WWW hs_post = new WWW(post_url);
		yield return hs_post; // Wait until the download is done
		
		if (hs_post.error != null)
		{
			print("There was an error posting the high score: " + hs_post.error);
		}
		StartCoroutine(GetScores());
	}
	
	/**
 	 * This function returns the top 5 scores in the database into a Text field.
 	 */
	IEnumerator GetScores()
	{
		// Get the scores from the MySQL DB to display in a GUIText.
		// remember to use StartCoroutine when calling this function!
		gameObject.GetComponent<Text>().text = "Loading Scores";
		WWW hs_get = new WWW(highscoreURL);
		yield return hs_get;
		
		if (hs_get.error != null)
		{
			print("There was an error getting the high score: " + hs_get.error);
		}
		else
		{
			gameObject.GetComponent<Text>().text = hs_get.text; // this is a Text that will display the scores in game.
		}
	}

	/**
 	 * This function is used to encrypt a string for use in the server side interactions.
 	 */
	public  string Md5Sum(string strToEncrypt)
	{
		System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
		byte[] bytes = ue.GetBytes(strToEncrypt);
		
		// encrypt bytes
		System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
		byte[] hashBytes = md5.ComputeHash(bytes);
		
		// Convert the encrypted bytes back to a string (base 16)
		string hashString = "";
		
		for (int i = 0; i < hashBytes.Length; i++)
		{
			hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
		}
		
		return hashString.PadLeft(32, '0');
	}

}
