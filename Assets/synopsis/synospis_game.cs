using UnityEngine;
using System.Collections;

public class synospis_game : MonoBehaviour {
	
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
		//synopsis of game
		GUI.color = Color.white;
		GUI.Label(new Rect (Screen.width/2-120,80, 400, 200), "About The Game", guistyle);	 
		GUI.Label(new Rect (Screen.width/2-500,130, 2000, 200), "On December 21, 2012, aliens from a near galaxy came with the intent to destroy the planet. ", guistyle_2);	 
		GUI.Label(new Rect (Screen.width/2-500,150, 2000, 200), "Upon their arrival, they stole an unstable nuclear core from a nearby military base, and planted it somewhere in the deserted Blossom City.", guistyle_2);	 
		GUI.Label(new Rect (Screen.width/2-500,170, 2000, 200), "Now Spruce Bayne, a highly trained mercenary who is well versed on the subject of alien intelligence, steps up to the plate", guistyle_2);	
		GUI.Label(new Rect (Screen.width/2-500,190, 2000, 200), "to save the world from nuclear detonation.", guistyle_2);	 
		
		GUI.Box (new Rect (0, Screen.height- 298, Screen.width, 300), "", guistyle_3);	
		GUI.color = Color.white;		
		selGridInt = GUI.SelectionGrid(new Rect(Screen.width/2-50, Screen.height/2 -60, 350, 80), selGridInt, selStrings, 2);	
		
		if(selGridInt==0) {
			Application.LoadLevel("Intro");
		}
		
		
		
		
	}
}
