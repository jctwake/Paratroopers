using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour {
	
	public Light glow;
	int count = 0;
	float increment = 0.13f;
	// Use this for initialization
	void Start () {
		glow.intensity = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		glow.intensity = glow.intensity + increment;
			count++;
		if(count >=60){
			increment = -increment;
			count = 0;
		}
		
		
	
	}
}
