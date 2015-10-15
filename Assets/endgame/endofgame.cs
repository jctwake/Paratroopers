using UnityEngine;
using System.Collections;

public class endofgame : MonoBehaviour {
	
	public GUIStyle guistyle; 
	public int selGridInt = 3;    
	private string[] selStrings = new string[] {"click to return to the main page"}; 
    	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI ()
	{		
		GUI.Label(new Rect (Screen.width/2 -200, 200,600, 100), "Game Over", guistyle);
		GUI.color = Color.white;		
		selGridInt = GUI.SelectionGrid(new Rect(Screen.width/2-125, Screen.height/2 +20, 550, 80), selGridInt, selStrings, 2);	
		
		if(selGridInt==0) {
			Application.LoadLevel("Intro");
		}
	}
		
            
			
		
		
			
		
}
