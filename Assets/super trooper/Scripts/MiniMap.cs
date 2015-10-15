using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour {

GameObject player;
public Camera minimapCam;
public float zoomFactor = 50;
public float markerHeight;	
public GameObject playerMarker;
public float x = 100;
public float y = 100;	
public float u = 100;	
public float v = 100;	

public Texture aTexture;

	// Use this for initialization
	void Start () {
	player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 camPos = new Vector3(player.transform.position.x, zoomFactor, player.transform.position.z);
		Vector3 markPos = new Vector3(player.transform.position.x, markerHeight, player.transform.position.z);
		minimapCam.transform.position = camPos;
		playerMarker.transform.position = markPos;
		//playerMarker.transform.rotation = player.rotation;
	}
	void OnGUI() {
	// poaition for player on mim map
	GUI.Box (new Rect ( Screen.width*.11822f	,Screen.height*.165f, 10,10 ), "");		
	
	// position for compass	
	GUI.DrawTexture(new Rect(0, 0, Screen.width*.27f, Screen.height*.319f), aTexture);
	

	}
}
