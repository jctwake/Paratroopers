using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	
	public float spawnChance = 0.007f;
	public Vector3 spawnArea = new Vector3(10f, 0f, 10f);
	public Enemy enemyPrefab;
	public Transform[] enemySpawns;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//randomly spawn enemies
		if (Random.value < spawnChance){
			Vector3 spawnTrans = new Vector3 (Random.Range(-.5f,.5f),Random.Range(-.5f,.5f),Random.Range(-.5f,.5f));
			spawnTrans.Scale(spawnArea);
			int randomIndex = Random.Range(0,enemySpawns.Length);
			Vector3 pos = enemySpawns[randomIndex].transform.position;
			//spawn enemy and put it in the right spot
			Enemy e = (Enemy)Instantiate(enemyPrefab);
			e.transform.position = pos + spawnTrans;
			
			//parent to us (the spawner) so that this object can receive messages on death
			e.transform.parent = transform;
		}
	}
}
