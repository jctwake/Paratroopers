using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	
float SpawnChance = 0.02f;
float MaxItem;
public GameObject item;
public Transform[] itemSpawns;
float currentItems = 0;
	
	
	void Start () {
		MaxItem = itemSpawns.Length;	
		
	}
	// Update is called once per frame
	void Update (){

		if(currentItems < MaxItem && Random.value < SpawnChance){
			int randSpawn = Random.Range(0, itemSpawns.Length);
			Vector3 pos = itemSpawns[randSpawn].transform.position;
			item = (GameObject)Instantiate(item);
			item.transform.position = pos;
			currentItems++;
		
			
		}
		transform.Rotate(0,Time.deltaTime * 50, 0);
		
	}
	
	
	void OnCollisionInfo(Collision info){
		
		print (info.gameObject.name) ;
		if(info.gameObject.tag == "Graphics"){
			print ("Dickbutt");
			Destroy(item);
			GameObject go = GameObject.FindGameObjectWithTag("Player");
			print (go.name);
			OnScreenDisplay osd = (OnScreenDisplay)go.GetComponent(typeof(OnScreenDisplay));
			osd.healing();
		}
		currentItems--;
	}
}