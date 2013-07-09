using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	public float timer;
	

	// Use this for initialization
	void Awake () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		
	if (timer <= 0)
		{
			Destroy(gameObject);
		}
	}
}
