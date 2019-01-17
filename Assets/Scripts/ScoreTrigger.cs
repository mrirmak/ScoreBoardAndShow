using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTrigger : MonoBehaviour {

	public GameObject SkorObjesi;

	public int KazanilanPuan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "top") {

			KazanilanPuan = 20;


			SkorObjesi.GetComponent<GetScore> ().PuanAldi (KazanilanPuan);



		}

	}
}
