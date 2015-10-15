using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public GUIStyle guistyle;
	public GUIStyle guistyle_2;
	public int selGridInt = 3;    
	private string[] selStrings = new string[] {"click to start game", "click to read about game  ", "click to see credits"}; 
    
	
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{		
		
		
		
        
		GUI.color = Color.black;		
	
		GUI.Label (new Rect (Screen.width/2-200, 100, 2000, 200), "Super Trooper", guistyle);	
		GUI.Box (new Rect (0, Screen.height- 298, Screen.width, 300), "", guistyle_2);	
		GUI.color = Color.white;		
		selGridInt = GUI.SelectionGrid(new Rect(Screen.width/2-125, Screen.height/2 -40, 350, 80), selGridInt, selStrings, 2);	
		
		if(selGridInt==0) {
			Application.LoadLevel("Super Trooper");
		}
		if(selGridInt==1) {
			Application.LoadLevel("about_game");
		}
		
		if(selGridInt==2) {
			Application.LoadLevel("credit");
		}
	}

}
