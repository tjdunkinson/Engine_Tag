using UnityEngine;
using System.Collections;

public class Player02 : MonoBehaviour {
	
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("HorizontalP2") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP2") * speed));
		}
		if (Input.GetAxis("VerticalP2") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP2") * speed));
		} 
	}
}
