using UnityEngine;
using System.Collections;

public class MoveOnPlayerInput : MonoBehaviour {

	public float halfArenaHeight;
	public float moveSpeed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

		transform.Translate(0, 0, translation, Space.World);

		transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -halfArenaHeight, halfArenaHeight));
	}
}
