using UnityEngine;
using System.Collections;

public class DayAndNight : MonoBehaviour {

	public float timeScale;

	private Quaternion startRotation;
	// Use this for initialization
	void Start () {
		startRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		float frame = Time.deltaTime / 360 * timeScale;
		transform.RotateAround (transform.position, Vector3.forward, frame);
	}
}
