using UnityEngine;
using System.Collections;

public class Projectile1 : MonoBehaviour {
	
	public float speed;
	public float damage;	


	// Use this for initialization
	void Start () {
		//start moving in the right direction
		rigidbody.velocity = transform.forward * speed;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision info){
			Destroy (gameObject);

		Enemy e = info.gameObject.GetComponent<Enemy>();
		if(e){
			e.Damage(damage * speed);
		}
		}

	}		
	
