using UnityEngine;
using System.Collections;

public class HealthMeter : MonoBehaviour {
	
	public int health = 20;

		
	void Update(){
		print ("Health of " + gameObject.name + ": " + health);
	}
	
	public int getHealth(){
		return health;
	}

	public void Damage(int amount){
		if(amount <= 0){
			return;
		}
		health = health - amount;		
	}
	void OnCollisionEnter(Collision info){
		if(info.gameObject.tag == "Weapon"){
			Damage(10);
		}
	}
}
