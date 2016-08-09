using UnityEngine;
using System.Collections;

public class KeyOne : MonoBehaviour {

	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	public void OnTriggerEnter(Collider collider){
		if ((collider.GetComponent<Player> ())&&(Scroll.setOne == true)) {
			PlayerPrefsManager.SetPlayer_X (collider.gameObject.transform.position.x + 3f);
			PlayerPrefsManager.SetPlayer_Y (collider.gameObject.transform.position.y );
			PlayerPrefsManager.SetPlayer_Z (collider.gameObject.transform.position.z );
			PlayerPrefsManager.SetVisitedKeyOne (1);

			Scroll.setTwo = true;
			levelManager.LoadLevel("Key1");
		}
	}
}		
