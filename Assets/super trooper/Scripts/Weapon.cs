using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	
	public Vector2 spread = Vector2.zero;
	public bool semiAutomatic = true;
	public float firingDelay = 0.25f;
	//public AudioSource[] music;
	public float yOffset;
	public float zOffset;
	public Projectile1[] bullets;
	public int selectedBullet = 0;
	int ammo;

	
	//public ParticleSystem p;
	
	float lastFireTime = 0f;

	// Use this for initialization
	void Start () {
		//music[0].loop = true;
		//music[0].Play();	
	}
	
	// Update is called once per frame
	void Update () {
		//should we be firing?
		bool delayPassed = Time.time - lastFireTime > firingDelay;
		bool buttonJustPressed = Input.GetMouseButtonDown(0);
		bool buttonCurrentlyHeld = Input.GetMouseButton(0);

		//Delay must have passed, the button should be down, and if semi-auto, just pressed
		ammo = OnScreenDisplay.getAmmo();
		if (Input.GetKeyDown(KeyCode.R)){
		Reload();	
		}
		
		
		
		
		if (delayPassed && buttonCurrentlyHeld && (!semiAutomatic || buttonJustPressed)){
			if( ammo == 0){
				return;
			}
		
			SendMessageUpwards("shooting", SendMessageOptions.DontRequireReceiver);
			//creates ParticleSystem and Projectile
			Projectile1 bullet = bullets[selectedBullet];
			Projectile1 p = (Projectile1)Instantiate(bullet);
			//ParticleSystem ps = (ParticleSystem)Instantiate(p);
			//ps.transform.position = transform.position;
			
			p.transform.position = transform.position;
			//set bullet's forward vector to be the camera's forward vector, plus any spread
			p.transform.forward = transform.forward;
			//p.transform.Rotate(90, -180, -360);
			//p.transform.forward += spread.x * p.transform.right * Random.Range(-1f, 1f);
			//p.transform.forward += spread.y * p.transform.up * Random.Range(-1f, 1f);
			
			//set bullet position to be *just* ahead of the camera
			p.transform.position = transform.position + (transform.forward * zOffset);
			p.transform.position = transform.position + (transform.up * yOffset);
			
			animation.CrossFade("Recoil");
			//update firing time for the delay
			lastFireTime = Time.time;
		}
	}
	
	void Reload (){
			GameObject go = GameObject.FindGameObjectWithTag("Player");
			OnScreenDisplay osd = (OnScreenDisplay)go.GetComponent(typeof(OnScreenDisplay));
			osd.reloading();
			
		}
}
