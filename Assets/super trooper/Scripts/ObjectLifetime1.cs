using UnityEngine;
using System.Collections;

public class ObjectLifetime1 : MonoBehaviour {
	
	public float lifetime = 5f;
	
	float startTime =0f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > lifetime)
			Destroy(gameObject);
	}
}
