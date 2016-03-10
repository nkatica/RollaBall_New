using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class CountDown : MonoBehaviour {
	float timeRemaining = 60;
	public Text countDownText;
	public Text loseText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI(){
		if (timeRemaining > 0) {
			countDownText.text = "Time Remaining: "+(int)timeRemaining;
		} else {
			countDownText.text = "Time's up!";
			loseText.text = "Game Over !";
			Time.timeScale = 0; 
		}
	}
}
