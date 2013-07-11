using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed = 10;
	public GameObject poof;
	public int playerNum;
	public GameObject sheild;
	
	private GameObject myPoof;
	private Vector3 colVector;
	private Color myColour;
	
	// Use this for initialization
	void Start () {
		
		myColour = renderer.material.color;
		sheild.renderer.material = this.gameObject.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Joystick 1
		if (Input.GetAxis("P"+playerNum+"J1H") != 0)
		{
			rigidbody.AddForce(transform.right * (Input.GetAxis("P"+playerNum+"J1H") * speed));
		}
		if (Input.GetAxis("P"+playerNum+"J1V") != 0)
		{
			rigidbody.AddForce(-transform.forward * (Input.GetAxis("P"+playerNum+"J1V") * speed));
		}
		
		//Joystick 2
		if (Input.GetAxis("P"+playerNum+"J2H") != 0)
		{
			Vector3 currentRot;
			currentRot = sheild.transform.rotation.eulerAngles;
			sheild.transform.rotation.eulerAngles.y = currentRot.y;
		}
		if (Input.GetAxis("P"+playerNum+"J2V") != 0)
		{
			Vector3 currentRot;
			currentRot = sheild.transform.rotation.eulerAngles;
			sheild.transform.rotation.eulerAngles.y = currentRot.y;
			
		} 
		sheild.transform.eulerAngles = new Vector3( 0, Mathf.Atan2(Input.GetAxis("P"+playerNum+"J2H"),-Input.GetAxis("P"+playerNum+"J2V"))*180/Mathf.PI, 0 );
	
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
