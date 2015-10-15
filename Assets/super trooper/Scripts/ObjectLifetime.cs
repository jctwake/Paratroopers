using UnityEngine;
using System.Collections;

public class ObjectLifetime : MonoBehaviour {
	
	public float lifetime = 5f;
	public ParticleSystem particleSystem;
	
	float startTime =0f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > lifetime){
			Destroy(gameObject);
			if(particleSystem) {
				ParticleSystem p = (ParticleSystem)Instantiate(particleSystem);
				p.transform.position = transform.position;
			}
		}
	}
}
