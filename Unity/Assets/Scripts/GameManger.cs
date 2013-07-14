using UnityEngine;
using System.Collections;

public class GameManger : MonoBehaviour {

	public GameObject p1,p2,p3,p4;
	
	private Player p1Script,p2Script,p3Script,p4Script;
	private float playerSpeed;
	private bool shieldActive;
	private float playerSpeedSlider = 20f;
	private float playerMass;
	private float playerMassSlider = 1;
	private float playerDrag;
	private float playerDragSlider = 1;
	private float TimeScale;
	private float timeSlider = 1;
	private int playerIt;
	// Use this for initialization
	void Start () 
	{
		p1Script = p1.GetComponent<Player>();
		p2Script = p2.GetComponent<Player>();
		p3Script = p3.GetComponent<Player>();
		p4Script = p4.GetComponent<Player>();
		
		playerIt = Random.Range(1, 4);
		
		if (playerIt == 1)
		{
			p1Script.It = true;
		}
		if (playerIt == 2)
		{
			p2Script.It = true;
		}
		if (playerIt == 3)
		{
			p3Script.It = true;
		}
		if (playerIt == 4)
		{
			p4Script.It = true;
		}

	
	}
	
	// Update is called once per frame
	void Update () {
		
		p1Script.speed = playerSpeed;
		p2Script.speed = playerSpeed;
		p3Script.speed = playerSpeed;
		p4Script.speed = playerSpeed;
		
		playerSpeed = playerSpeedSlider;
		
		p1.rigidbody.drag = playerDrag;
		p2.rigidbody.drag = playerDrag;
		p3.rigidbody.drag = playerDrag;
		p4.rigidbody.drag = playerDrag;
		
		playerDrag = playerDragSlider;
		
		p1.rigidbody.mass = playerMass;
		p2.rigidbody.mass = playerMass;
		p3.rigidbody.mass = playerMass;
		p4.rigidbody.mass = playerMass;
		
		playerMass = playerMassSlider;
		
		Time.timeScale = TimeScale;
		TimeScale = timeSlider;
		
		if (playerDrag < 0)
		{
			playerDrag = Mathf.Infinity;
		}
		
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel("Menu");
		}
		
		
		
		if (Input.GetKey(KeyCode.R))
		{
			p1Script.It = false;
			p2Script.It = false;
			p3Script.It = false;
			p4Script.It = false;
			
			playerIt = Random.Range(0, 4);
		}
			
			
			
	
	}
	void OnGUI ()
	{
		playerSpeedSlider = GUI.HorizontalSlider(new Rect(25, 20, 200, 30), playerSpeedSlider,.0001f,50f);		
		GUI.Box(new Rect(55, 5, 100, 30),"Speed = " + playerSpeed,GUIStyle.none);
		
		playerDragSlider = GUI.HorizontalSlider(new Rect(25, 50, 200, 30), playerDragSlider,.0001f,3f);		
		GUI.Box(new Rect(55, 35, 100, 30),"Drag = "+ playerDrag,GUIStyle.none);
		
		playerMassSlider = GUI.HorizontalSlider(new Rect(25, 80, 200, 30), playerMass,.0001f,3f);		
		GUI.Box(new Rect(55, 65, 100, 30),"Mass = " + playerMass,GUIStyle.none);
		
		timeSlider = GUI.HorizontalSlider(new Rect(25, 110, 200, 30), timeSlider,0f,12f);
		GUI.Box(new Rect(55, 95, 100, 30),"Time = " + TimeScale,GUIStyle.none);
		
    }
}
