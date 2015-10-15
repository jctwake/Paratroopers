using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

public Core corePrefab;
public Transform[] CoreSpawns;

	// Use this for initialization
	void Start () {
		
		int randomIndex = Random.Range(0,CoreSpawns.Length);
		Vector3 pos = CoreSpawns[randomIndex].transform.position;
		Core c = (Core)Instantiate(corePrefab);
		c.transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
