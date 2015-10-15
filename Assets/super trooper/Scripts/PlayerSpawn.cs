using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {
	
	public Transform[] SpawnPoints;  // Array of spawn points to be used.
	bool PlayerAlive = false;
	public GameObject PlayerPF; // Array of different Enemies that are used.
	//public float amountEnemies = 20f;  // Total number of enemies to spawn.
	//public float spawnDelay = .3f;
	//float lastSpawnTime = 0f;
	//bool NewWave = false;
	//int currentSpawn;
	//int WaveNumber = 0;
	
	
	void Start()
	{
	}
	
	void Update() 
	{ 
		//NumberEnemies = (GameObject.FindGameObjectsWithTag("Enemy").Length);
	
		if(PlayerAlive == false){
		   
		   //WaveNumber += 1;
		   SpawnPlayer();
		}
	} 
	
	void SpawnPlayer () {
		//	Debug.Log(Time.time);
	    //	if (Time.time - lastSpawnTime > spawnDelay) {
			
			int randomIndex = Random.Range(0,SpawnPoints.Length);
			//GameObject p = (GameObject)Instantiate(PlayerPF);
			PlayerPF.transform.position = (SpawnPoints[randomIndex].transform.position);

		//NewWave = false;
		PlayerAlive = true;
	}
	

	

}

 