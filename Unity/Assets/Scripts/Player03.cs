using UnityEngine;
using System.Collections;

public class Player03 : MonoBehaviour {
	
	public float speed = 10;
	public ParticleSystem poof;
	private Vector3 colVector;
	private Color myColour;
	
	// Use this for initialization
	void Start () {
		
		myColour = renderer.material.color;
		
	
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
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			colVector = (transform.position / 2) + (other.gameObject.transform.position / 2);
			Instantiate (poof,colVector, Quaternion.identity);
		}
	}
}
