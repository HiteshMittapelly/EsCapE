using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	private bool inside = false;
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	public void OnTriggerEnter(Collider collider){
		if (collider.GetComponent<Player> ()&&!inside) {
			
			PlayerPrefsManager.SetPlayer_X (collider.gameObject.transform.position.x - 5f);
			PlayerPrefsManager.SetPlayer_Y (collider.gameObject.transform.position.y );
			PlayerPrefsManager.SetPlayer_Z (collider.gameObject.transform.position.z );
			PlayerPrefsManager.SetVisitedKey (1);
			inside = true;

			Scroll.setOne = true;
			levelManager.LoadLevel("Key");

		}
	}
	void OnTriggerExit(){
		inside = false;
	}
}
