using UnityEngine;
using System.Collections;

public class Paratroop : MonoBehaviour {
	public float fallingSpeed;
	bool isParatrooping = true;
	
	
	void Start()
	{
		
	}
	// Update is called once per frame
	void Update () {
		if(isParatrooping == true){
			Fall ();
		}
	}
	
	void Fall(){
		transform.Translate(new Vector3(0f, (Time.deltaTime*(-fallingSpeed)), 0f));
	}
	
	void OnCollisionEnter(Collision info){
		
		if(info.gameObject.name == "Terrain"){
		Destroy(gameObject);
		}
		}
	}

