using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetScore : MonoBehaviour {
	public int skor; //Score
	//Tablo Skoru
	public Text SkorTablo; //ScoreTable

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PuanAldi(int puan){
		skor += puan;
		SkorTablo.text = skor.ToString ();

	}
}
