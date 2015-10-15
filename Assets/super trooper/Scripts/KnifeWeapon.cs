using UnityEngine;
using System.Collections;

public class KnifeWeapon : MonoBehaviour {
	
	
	public float knifeDelay;
	float lastKnifeTime = 0;
	public GameObject Knife;
	public float damage = 5;
		
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		bool DelayPassed = Time.time - lastKnifeTime > knifeDelay;
		bool rButtonDown = Input.GetMouseButtonDown(1);
		if (DelayPassed && rButtonDown){
		animation.CrossFade("Knifechop");
			
			lastKnifeTime = Time.time;
		}	
	}
	
	void OnCollisionEnter(Collision info){
		Enemy e = info.gameObject.GetComponent<Enemy>();
		if(e){
			e.Damage(damage);
		}
	}



}

