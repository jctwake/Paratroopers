using UnityEngine;
using System.Collections;

public class OnScreenDisplay : MonoBehaviour
{
	
	public GUIStyle guistyle;
	public static float health = 150f;
	private string ammostring = "";
	static int x = 50;
	bool dead = false;
	public GUIStyle guiStyle;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		// go to end game screen if you die
		if(health <= 0){
			Application.LoadLevel("end_game");
			// resets heakth evry game
			health = 300f;
		}
		print (health);
		// prints how long the player has been in game, used to compare times 
		//if(Input.GetButtonDown("r")){
			//reloading();
		//}
	}
	
	public void healing () {
		if(health > 200){
			health += (300-health);
		}
		else{
			health += 100f;
		}
	}
	
	public void shooting (){
		x--; // lose bullet
	}
	
	public void reloading ()	{ 
		x = 50;	//reload bullets back to full, 20 bullets
}

	public void Damage ()
	{
		health -= 20;	 //if hit by enemy lose ammo
		
	}
	
	public static int getAmmo()
	{
		return x;
	}
	
	public static float gethealth()
	{
		return health;
	}
	
	void OnGUI ()
	{		
		ammostring = "";	
		for (int i=0; i<x/2; i++) {
			ammostring += " | ";		
		}
		
		// Declarations
            
		string xNum = "";
		xNum = x.ToString ();		
		
		// health meter for player
		GUI.color = Color.red;		
		GUI.Box (new Rect (10f, 450f, health, 20f), "");	
		GUI.color = Color.yellow;
		GUI.Label (new Rect (15f, 450f, 100f, 20f), "Health: " + health);	
		GUI.Box (new Rect (10f, 475f,350f, 20f), "");	
		
		GUI.color = Color.yellow;	
		GUI.Label (new Rect (60f, 475f, 300f, 20f), "(" + xNum + ")");	
		GUI.Label (new Rect (15f, 475f, 100f, 20f), "Ammo:");	
		GUI.Label (new Rect (84f, 475f, 450f, 20f), ammostring);
		
			GUI.Box (new Rect (Screen.width/2, Screen.height/2, 0, 25), "");	
			GUI.Box (new Rect (Screen.width/2, Screen.height/2, 0, -20), "");	
			GUI.Box (new Rect (Screen.width/2, Screen.height/2, 25, 0), "");	
			GUI.Box (new Rect (Screen.width/2, Screen.height/2, -20, 0), "");	
			
		
	}
	
	void OnControllerColliderHit(ControllerColliderHit info){
		if(info.gameObject.tag == "Weapon"){
			Damage();
		}
		else if(info.gameObject.tag == "Item"){
			print ("Dickbutt");
			healing ();		
			Destroy(info.gameObject);
		}
	}

}