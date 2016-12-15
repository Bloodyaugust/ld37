using UnityEngine;
using System.Collections;

public class NotifyScoreKeeper : MonoBehaviour {

	public ScoreController scoreKeeper;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Boundary") {
			if (collision.transform.position.x < 0) {
				scoreKeeper.AddAIScore();
			} else {
				scoreKeeper.AddPlayerScore();
			}
		}
	}
}
