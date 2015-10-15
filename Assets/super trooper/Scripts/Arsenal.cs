using UnityEngine;
using System.Collections;

public class Arsenal : MonoBehaviour {

	
	public Weapon[] guns;
	Weapon selected;
	public int index = 0;
	public float xOffset;
	public float yOffset;
	public float zOffset;
	float changeDelay = 1;
	bool delayPassed;
	float lastChangeTime = 0f;
		
	// Use this for initialization
	void Start () {
		selected = (Weapon)Instantiate(guns[0]);
		selected.transform.parent = transform;
		selected.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
		selected.transform.position = transform.position + new Vector3(0.95f, -0.3f, 3);
		lastChangeTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		delayPassed = Time.time - lastChangeTime > changeDelay;
		if(Input.GetKey(KeyCode.LeftShift) && delayPassed){
			if(index == guns.Length - 1){
				index = 0;
			}
			else{
				index++;
			}
			Destroy(selected.gameObject);
			selected = (Weapon)Instantiate(guns[index]);
			selected.transform.parent = transform;
			selected.transform.forward = transform.forward;

			if(selected.name == "Gun(Clone)")
			{
				selected.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
				selected.transform.position = transform.position + new Vector3(0.95f, -0.3f, -3);		
			}
			else{
						selected.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
						selected.transform.position = transform.position + new Vector3(0.8f, -0.3f, 1);	
			}
			lastChangeTime = Time.time;
		}
	
	}
}
