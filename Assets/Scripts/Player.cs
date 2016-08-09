using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject Bullet;
	public GameObject Zombie;

	private LevelManager levelManager;
	private GameObject Projectile;
	private GameObject Zombieman;
	private float health = 500;
	private float posX, posY, posZ;
	private bool dropped = false;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		posX = PlayerPrefsManager.GetPlayer_X();
		posY = PlayerPrefsManager.GetPlayer_Y();
		posZ = PlayerPrefsManager.GetPlayer_Z();

		if (PlayerPrefsManager.GetVisitedKey() == 1) {
			transform.position = new Vector3 (posX-10,posY,posZ);
			PlayerPrefsManager.SetVisitedKey (0);
		}
		else if(PlayerPrefsManager.GetVisitedKeyOne() == 1) {
			transform.position = new Vector3 (posX,posY,posZ+5);
			PlayerPrefsManager.SetVisitedKeyOne(0);
		}
		InvokeRepeating ("CreateZombie", 2f, 13f);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B)&&!dropped) {
			dropped = true;
			posX = transform.position.x;
			posY = transform.position.y;
			posZ = transform.position.z;
			Projectile =Instantiate (Bullet, new Vector3 (posX, 20.067f, posZ), Quaternion.identity) as GameObject;
			Invoke ("ChangeDropped", 10f);

		}
	}
	void OnTriggerEnter(Collider collider){
		
		if (collider.GetComponent<Zombie> ()) {
			Debug.Log("into zombie cmponent");
			Damage ();
		}
	}
	void Damage(){
		if (health >= 500) {
			
			health -= 500;
		} else {
			Destroy (gameObject);
			levelManager.LoadLevel ("Lose");

		}
	}
	void ChangeDropped(){
		
		dropped = false;
		Destroy (Projectile);

	}
	void CreateZombie(){
		
		Vector3 pos = transform.position;
		pos.z = pos.z + 20f;

		Zombieman = Instantiate (Zombie , pos , Quaternion.identity) as GameObject;
	}
}
 