using UnityEngine;
using System.Collections;

public class KeyTwo : MonoBehaviour {
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider collider){
		if ((collider.GetComponent<Player> ())&&(Scroll.setTwo == true)) {
			

			levelManager.LoadLevel("Won");
		}
	}
}
