using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {
	
	public bool lockMouse = true;
	public float sensitivity = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//If lockMouse is true, hide the cursor and re-center each frame
		//you can hit the Escape key to temporarily unlock
		Screen.lockCursor = lockMouse;
		
		//get mouse movement from the Input system
		Vector3 mouseMovement = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
		mouseMovement *= sensitivity;
		
		//adjust camera rotation
		transform.localEulerAngles += mouseMovement;	
	
	}
		
	
}
