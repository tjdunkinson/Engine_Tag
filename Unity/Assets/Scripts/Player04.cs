using UnityEngine;
using System.Collections;

public class Player04 : MonoBehaviour {
	
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("HorizontalP4") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP4") * speed));
		}
		if (Input.GetAxis("VerticalP4") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP4") * speed));
		} 
	}
}
