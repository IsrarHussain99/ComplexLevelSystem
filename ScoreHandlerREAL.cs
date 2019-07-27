using UnityEngine;
using System.Collections;

public class ScoreHandlerREAL : MonoBehaviour {

	//public LvlManager scoreman;
	public int ScorerPoints=1;

	public GameObject manager;
		LvlManager scoreman;
	public AudioClip MyClip;


	// Use this for initialization
	void Awake () {
		scoreman = manager.GetComponent<LvlManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Score") {
			GetComponent<AudioSource>().PlayOneShot(MyClip);
			scoreman.AddPoints(ScorerPoints);

				}


	}
}
