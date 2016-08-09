using UnityEngine;
using System.Collections;

public class lost : MonoBehaviour {
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		PlayerPrefsManager.SetVisitedKey (0);
		PlayerPrefsManager.SetVisitedKeyOne(0);
		Scroll.setOne = false;
		Scroll.setTwo = false;
		Scroll.done = false;
		Scroll.done2 = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.N)) {
			levelManager.LoadLevel ("Start");
		}
	}
}
