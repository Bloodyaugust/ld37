using UnityEngine;
using System.Collections;

public class BallReset : MonoBehaviour {

	public float initialForce;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

		Reset();
	}

	// Update is called once per frame
	void Update () {

	}

	void Reset () {
		transform.position = new Vector3(0, 3, 0);
		rb.velocity = Vector3.zero;

		if (Random.value <= 0.5) {
			rb.AddForce(new Vector3(initialForce, 0, 0));
		} else {
			rb.AddForce(new Vector3(-initialForce, 0, 0));
		}
	}
}
