using UnityEngine;
using System.Collections;

public class HealthBoxHit : MonoBehaviour {

	void OnCollisionInfo(Collision info){
		
		print (info.gameObject.name) ;
		if(info.gameObject.tag == "Graphics"){
			print ("Dickbutt");
			GameObject go = GameObject.FindGameObjectWithTag("Player");
			print (go.name);
			OnScreenDisplay osd = (OnScreenDisplay)go.GetComponent(typeof(OnScreenDisplay));
			osd.healing();
			Destroy(gameObject);
		}
		//currentItems--;
	}
}
