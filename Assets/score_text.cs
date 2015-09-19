using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class score_text : MonoBehaviour {

	public float score = 0f;
	public Text Text;

	// Use this for initialization
	void Start () {
		Text.text = "Score: " + score;
	
	}
	
	// Update is called once per frame
	void Update () {
		UpdateScore();
	}

	public void incrementScore() {
		score = score + 1f;
	}

	public void UpdateScore(){
		Text.text = "Score: " + score;
		if (score == 6) {
			Text.text = "You have won! Score: " + score;
		}
	}

}
