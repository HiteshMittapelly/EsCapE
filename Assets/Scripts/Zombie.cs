using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	private float health = 500f;
	// Use this for initialization
	void Start () {
		GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl> ().target = FindObjectOfType<Player> ().transform;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider collider){
		if (transform.position.y < 20f) {
			Destroy (gameObject);
		}
		if (collider.GetComponent<Bullet> ()) {
			Damage ();
		}
	}
	void Damage(){
		if (health >= 50) {
			
			health -= 50;
		} else {
			Destroy (gameObject);
		}
	}
}
