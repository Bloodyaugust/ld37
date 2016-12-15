using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public TextMesh aiScoreText;
	public TextMesh playerScoreText;

	int aiScore = 0;
	int playerScore = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void AddAIScore () {
		aiScore++;
		aiScoreText.text = aiScore.ToString();
	}

	public void AddPlayerScore () {
		playerScore++;
		playerScoreText.text = playerScore.ToString();
	}
}
