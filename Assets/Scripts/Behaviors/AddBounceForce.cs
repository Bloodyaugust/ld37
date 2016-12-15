using UnityEngine;
using System.Collections;

public class AddBounceForce : MonoBehaviour {

	public float forceAmount;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision collision) {
		if (collision.transform.position.z >= transform.position.z) {
			collision.rigidbody.AddForce(new Vector3(0, 0, forceAmount));
		} else {
			collision.rigidbody.AddForce(new Vector3(0, 0, -forceAmount));
		}
	}
}
