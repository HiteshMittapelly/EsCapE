using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public static bool setOne = false;
	public static bool setTwo = false;

	public static bool done2 = false;
	public static bool done = false;


	private Key key;
	private KeyOne keyOne;
	private KeyTwo keyTwo;
	// Use this for initialization
	void Start () {

		key = this.GetComponentInChildren<Key> ();
		key.GetComponent<BoxCollider>().isTrigger = true;
		keyOne = this.GetComponentInChildren<KeyOne> ();
		keyOne.GetComponent<BoxCollider>().isTrigger = false;
		keyTwo = this.GetComponentInChildren<KeyTwo> ();
		keyTwo.GetComponent<BoxCollider>().isTrigger = false;
	}

	public void setOnefunc(){
		done = true;
		if(PlayerPrefsManager.GetVisitedKey() == 1)
		keyOne.GetComponent<BoxCollider>().isTrigger = true;
	}
	public void setTwofunc(){
		done2 = true;
		if(PlayerPrefsManager.GetVisitedKeyOne() == 1)
		keyTwo.GetComponent<BoxCollider>().isTrigger = true;
	}
	// Update is called once per frame
	void Update () {
		if (setOne && !done) {
			setOnefunc ();
		}
		if (setTwo&& !done2) {
			setTwofunc ();
		}

	}
}
