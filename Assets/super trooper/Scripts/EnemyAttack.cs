using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	// Use this for initialization
float EnelastFireTime = 0f;
float EnefiringDelay = 0.8f;
	//float animateDelay = 0.05f;
	//float startTime= 0;
public Projectile1 ebullets;
public float xOffset;
public float yOffset;
public float zOffset;
public float xAngleOffset;

	
	// Update is called once per frame
		public void Attack(bool isAttack){
			if (isAttack == true){
				bool EnedelayPassed = Time.time - EnelastFireTime > EnefiringDelay;
			if (EnedelayPassed) {
				//startTime = Time.time;
				//animation.CrossFade("shooting");
				//if(Time.time - startTime > animateDelay){
					animation.CrossFade("shoot");
				Projectile1 eb = (Projectile1)Instantiate(ebullets);
					//set bullet's forward vector to be the camera's forward vector, plus any spread
				eb.transform.forward = transform.forward;
					//set bullet position to be *just* ahead of the camera
				//eb.transform.position = transform.position;
				eb.transform.position = transform.position + new Vector3(5.3f, 5.5f, 0);
				eb.transform.rotation = transform.rotation;
				//eb.transform.position.y = transform.position.y + (yOffset);
				//eb.transform.position.x = transform.position.x + (xOffset);
				//Vector3 offSetVector = new Vector3(transform.right * xOffset, transform.up * yOffset, transform.forward * zOffset);
				//eb.transform.position = transform.position + offSetVector;
				//eb.transform.rotation = transform.rotation + (transform.Rotate
						
				EnelastFireTime = Time.time;
				}
				
				}
			}
		}
		
	//}
