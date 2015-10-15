using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
		
	public float Speed;
	public float Rotation;
	public float ShootRange = 60;
	public float velocity;
	bool isFollow = false;
	public bool isAttack = false;
	bool found = false;
	GameObject objectTarget;
	Transform target;
	EnemyAttack at;

	void Follow(){
		
		if (isFollow == true) {	
			animation.CrossFade("walking");
		Speed = 20;
		Vector3 relativePos = target.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos + Random.insideUnitSphere * 5 );
		transform.rotation = Quaternion.Slerp(transform.rotation,rotation,0.01f);
		transform.Translate(0,0,Speed*Time.deltaTime);
		}
	}
	// Update is called once per frame
	void Update () {
		objectTarget = GameObject.FindGameObjectWithTag("Player");
		if(objectTarget.name == "FirstPersonFab(Clone)"|| objectTarget.name == "FirstPersonFab"){
			found = true;
		}
		else{
			return;
		} 
		if(found == true){
		target = objectTarget.transform;
		at = GetComponent<EnemyAttack>();
		float distance = Vector3.Distance(transform.position,target.transform.position);
		if (distance <= ShootRange * 2)
			isFollow = true;
			isAttack = false;
		
		if (distance <= ShootRange)	{
			isFollow = false;
			isAttack = true;
			
		}
			if (isFollow == true){
			Follow();
		}
		if (isAttack == true){
			at.Attack(isAttack);	
			//transform.position = targetpos;
			Transform x = transform;
			x.LookAt(target.position);
			Speed = 1;
			
		}
			
		}
		}
	}

		