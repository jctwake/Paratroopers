using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	//int speed;
	public ParticleSystem particleSystem;
	public float Health = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		 // makes enemky move in direction up.
		//gameObject.transform.Translate(0f, Time.deltaTime * speed, 0f);
	}
	void OnCollisionEnter(Collision info){
		
		//SendMessageUpwards("enemyKilled", SendMessageOptions.DontRequireReceiver);
		//SendMessageUpwards("EnemyDied", SendMessageOptions.DontRequireReceiver);

		// destroy object
		
		/*Destroy(gameObject);
		source.Play();
		ParticleSystem p = (ParticleSystem)Instantiate(particleSystem);
		p.transform.position = transform.position;*/			
	}
	
public void Damage(float amount){
		//Don't do negative damage
		if (amount < 0){
			return;
		}
		
		Health = Health-amount;
		print (Health);
		if (Health <= 0){
		//tag object for destruction
			Destroy(gameObject);
			ParticleSystem p = (ParticleSystem)Instantiate(particleSystem);
		p.transform.position = transform.position + new Vector3 (0f, 9f, 0f);
			p.Play();
			print (Health);

			
			//let parent (spawner) know that we died
			//SendMessageUpwards("enemyKilled", SendMessageOptions.DontRequireReceiver);
			//SendMessageUpwards("EnemyDied", SendMessageOptions.DontRequireReceiver);
		}
		
		else{
	
		}
	}
}
