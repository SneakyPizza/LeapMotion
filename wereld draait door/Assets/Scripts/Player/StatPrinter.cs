using UnityEngine;
using System.Collections;

public class StatPrinter : MonoBehaviour {

	GameObject player;
	Score playerScore;
	Timer playerTime;

	void Start()
	{
		player = GameObject.Find("Player");
		playerScore  = player.GetComponent<Score>();
		playerTime = player.GetComponent<Timer>();
	}
	void OnGUI()
	{
		GUI.TextField(new Rect(10, 10, 200, 200), "score: " + playerScore.getScore()+ " Elapsed time: "+  playerTime.getSecElapsed() , 25);
	}
}
