using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed = 10;
	public GameObject poof, myPoof;
	public int playerNum;
	
	private Vector3 colVector;
	private Color myColour;
	
	// Use this for initialization
	void Start () {
		
		myColour = renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("HorizontalP"+playerNum) != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("HorizontalP"+playerNum) * speed));
		}
		if (Input.GetAxis("VerticalP"+playerNum) != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("VerticalP"+playerNum) * speed));
		}  
	}
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			colVector = (transform.position / 2) + (other.gameObject.transform.position / 2);
			myPoof = Instantiate (poof,colVector, Quaternion.identity) as GameObject;
			myPoof.particleSystem.startColor = myColour;
		}
	}
}
