using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExtraLifeScore : MonoBehaviour {
	//variables

	public static int score;
	public int scoreRetrieve;
	private int highscore;
	public Text Hightext;
	public Text Scoretext;
	
	// Use this for initialization
	void Start () {
		//gets the last saved score
		//PlayerPrefs.GetInt ("scorePref");
		//sets it to the score
		scoreRetrieve = PlayerPrefs.GetInt ("scorePref");
		score = scoreRetrieve;

		PlayerPrefs.GetInt ("highscorePref");
		highscore = PlayerPrefs.GetInt ("highscorePref");
	}
	
	// Update is called once per frame
	void Update ()
	{
		

		{
			if (score > highscore)
				highscore = score;
			PlayerPrefs.SetInt ("highscorePref", highscore);
		}
		// handles the highscore text element
		{
			Hightext.text = "Best " + highscore;
		}
		// handles the score text element
		{
			Scoretext.text = "" + score;
		}
	}
	public void AddPoints(int points)
	{
		score += points;
	}

	public void Plus1Point(int Point1)
	{
		//showad
		GameObject.Find("ShowAd").GetComponent<UnityAdsExample>().ShowAd();
		score += 1;
		//showgameobject 1 point added
	}

}
