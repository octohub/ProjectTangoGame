using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class countDownText : MonoBehaviour {
	
	public float timeInterval = 1f;
	public Text Text;
	public float totalTime = 10f;
	private float currentTime = 0;
	public Time time;
	
	// Use this for initialization
	void Start () {
		Text.text = "Time Left: " + totalTime;
		
	}
	
	// Update is called once per frame
	void Update () {
		decrementTime ();
		UpdateTime();
	}
	
	public void decrementTime() {
		if (Time.time - currentTime > timeInterval && totalTime > 0) {
			currentTime = Time.time;
			totalTime = totalTime - 1;
		}


	}
	
	public void UpdateTime(){
		Text.text = "Time Left: " + totalTime;
		if (totalTime == 0) {
			Text.text = "GAME OVER!";
		}
	}
	
}
