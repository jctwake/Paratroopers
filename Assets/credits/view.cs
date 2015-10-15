using UnityEngine;
using System.Collections;

public class view : MonoBehaviour {
	public GUIStyle guistyle;
	public GUIStyle guistyle_2;
	public GUIStyle guistyle_3;
	private  int selGridInt = 1;
	private string[] selStrings = new string[] {"click to return to intro"};
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
	GUI.color = Color.white;	
	GUI.Label(new Rect (Screen.width/2-20,80, 200, 200), "Credits", guistyle_3);	
	GUI.Label(new Rect(Screen.width/2- 120, 180, 600, 200), "Mitchell Freedman -  Level Designer & Assistant Art Director", guistyle);
	GUI.Label(new Rect(Screen.width/2-120, 160, 300, 200), "Josh Thomas - Co Game Designer ", guistyle);
	GUI.Label(new Rect(Screen.width/2-120, 140, 300, 200), "Tim Tse - Co Game Designer ", guistyle);
	GUI.Label(new Rect(Screen.width/2 - 120, 120, 300, 200), "Cameron  Barge - Head Art Director", guistyle);
		
		GUI.Box (new Rect (0, Screen.height- 298, Screen.width, 300), "", guistyle_2);	
		GUI.color = Color.white;		
		selGridInt = GUI.SelectionGrid(new Rect(Screen.width/2-50, Screen.height/2 -60, 350, 80), selGridInt, selStrings, 2);	
		
		if(selGridInt==0) {
			Application.LoadLevel("Intro");
		}
		
		
		
		
	}
	
}
