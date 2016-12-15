using UnityEngine;
using System.Collections;

public class BallFollow : MonoBehaviour {

	public GameObject ball;
	public float followSpeed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float actualSpeed = followSpeed * Time.deltaTime;
		float newZ = transform.position.z;
		float zDistance = Mathf.Abs(ball.transform.position.z - transform.position.z);

		if (zDistance <= actualSpeed) {
			newZ = ball.transform.position.z;
		} else {
			if (ball.transform.position.z > transform.position.z) {
				newZ = transform.position.z + actualSpeed;
			} else if (ball.transform.position.z < transform.position.z) {
				newZ = transform.position.z - actualSpeed;
			}
		}

		transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
	}
}
