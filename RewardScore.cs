using UnityEngine;
using System.Collections;


public class RewardScore : MonoBehaviour {
	
	//variables
	public int PlusPoints = 2;
    public static bool AdWatched = false;
	
	// Use this for initialization
	void Awake () {
	    //PlusPoints = LvlManager.score;
	PlusPoints = 2;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	   if(AdWatched) // checks to see if players has watched the ad. if true 2 points will be added.
		{
			PlusPoints = +1;
		}
		       
 
	
}
}
