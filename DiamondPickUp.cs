using UnityEngine;
using System.Collections;

public class DiamondPickUp : MonoBehaviour {

	void OnTriggerEnter(Collider coll) 
	{
		if(coll.gameObject.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
}