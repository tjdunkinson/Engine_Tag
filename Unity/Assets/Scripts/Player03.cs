using UnityEngine;
using System.Collections;

public class Player03 : MonoBehaviour {
	
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("HorizontalP3") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP3") * speed));
		}
		if (Input.GetAxis("VerticalP3") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP3") * speed));
		} 
	}
}
