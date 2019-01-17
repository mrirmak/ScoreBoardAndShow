using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour {
	public Text[] highScores; //Burada Textler


	int[] highScoreValues;// Burada skorları tutacağız


	// Use this for initialization
	void Start () {
		highScoreValues = new int[highScores.Length]; //Kaç textim varsa o kadar atadığım, o kadar skor değeri tutuyor;

		for (int x=0; x<highScores.Length; x++){
			highScoreValues [x] = PlayerPrefs.GetInt ("highScoreValues" + x); //Kaçıncı değere gittiğimize bakıyoruz

		}
		DrawScores ();
	}

	//Skoru kaydediyoruz
	void SaveScores(){
		for (int x=0; x < highScores.Length; x++){
			PlayerPrefs.SetInt ("highScoreValues" + x,highScoreValues[x]); //Değeri Set ediyoruz (atıyoruz,kaydediyoruz)

		}
	}

	public void CheckForHighScore(int _value){
		for (int x=0; x<highScores.Length; x++){
			if (_value > highScoreValues [x]) {
				for (int y = highScores.Length - 1; y > x; y--) {
					highScoreValues [y] = highScoreValues [y - 1];

				}

				highScoreValues [x] = _value;

				DrawScores ();
				SaveScores ();
				break;

			}
		}
	}

	//Ekrana yazacağız
	void DrawScores(){
		for (int x=0; x<highScores.Length; x++){
			highScores [x].text = highScoreValues [x].ToString(); //Değeri Stringe çevirip texte bastık
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F12)) {
			Debug.Log ("F12 Basıldı");

		}
	}
}
