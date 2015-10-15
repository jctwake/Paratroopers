using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour {
	
	public float speed;
	public float damage;
	// Use this for initialization
	void Start () {
			rigidbody.velocity = transform.forward * speed;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision info){
	}
}
