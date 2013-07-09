using UnityEngine;
using System.Collections;

public class Player02 : MonoBehaviour {
	
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
		
		if (Input.GetAxis("HorizontalP2") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP2") * speed));
		}
		if (Input.GetAxis("VerticalP2") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP2") * speed));
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
