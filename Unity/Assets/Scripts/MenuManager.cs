using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	
	public float buttonWidth = 100, buttonHieght = 100;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	
	}
	void OnGUI ()
	{
	if (GUI.Button(new Rect(((Screen.width/2) - (buttonWidth/2)),((Screen.height/2) - 50),buttonWidth,buttonHieght),"Play"))
		{
			Application.LoadLevel("Tag");
		}
	if (GUI.Button(new Rect(((Screen.width/2) - (buttonWidth/2)),((Screen.height/2) + 50),buttonWidth,buttonHieght),"Exit"))
		{
			Application.Quit();
		}
	}
}
