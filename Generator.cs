using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public Rigidbody PlatformPrefab;
	public Transform Platform;


	void OnTriggerEnter(Collider coll) 
	{
		if(coll.gameObject.tag == "Player")
		{
			Instantiate (PlatformPrefab, Platform.position, Platform.rotation);
		}
	}

}
