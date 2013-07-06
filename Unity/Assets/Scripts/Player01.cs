using UnityEngine;
using System.Collections;

public class Player01 : MonoBehaviour {
	
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("HorizontalP1") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP1") * speed));
		}
		if (Input.GetAxis("VerticalP1") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP1") * speed));
		}  
	}
}
