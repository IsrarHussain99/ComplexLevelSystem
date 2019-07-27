using UnityEngine;
using System.Collections;

public class ScoreHandlerExtraLife : MonoBehaviour {

	//public LvlManager scoreman;
	public int ScorerPoints=1;

	public GameObject manager;
	ExtraLifeScore scoreman;
	public AudioClip MyClip;


	// Use this for initialization
	void Awake () {
		scoreman = manager.GetComponent<ExtraLifeScore> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Score") {
			GetComponent<AudioSource>().PlayOneShot(MyClip);
			scoreman.AddPoints(ScorerPoints);

				}


	}
}
