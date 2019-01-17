using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject LeaderBoardObject;
	public GameObject ScoreObject;
	public float time = 15f;
	public bool started;
	public GameObject ball;
	public Text TimeTex;

	bool WriteScore;
	// Use this for initialization
	void Start () {
		started = true;
		WriteScore = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (started) {
			time -= Time.deltaTime;
			TimeTex.text = "Time:" +time.ToString ();
		}

		if (time <= 0.009) {
			started = false;
			time = 0f;
			ball.SetActive (false); //GameEnd

			if (WriteScore) { //For blocking dublicate score

			LeaderBoardObject.GetComponent<LeaderBoard> ().CheckForHighScore (ScoreObject.GetComponent<GetScore> ().skor); //SaveScore
				WriteScore=false;
			}
		}
	}


}
