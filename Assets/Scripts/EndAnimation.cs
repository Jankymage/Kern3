using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour {

	public GameObject objectLeft;
	public GameObject objectRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//zet de knoppen aan begin animatie uit en aan eind weer aan
	void ActivateButtons(){
		if(objectLeft.activeSelf == true){
			objectLeft.SetActive(false);
			objectRight.SetActive(false);
		}
		else{
			objectLeft.SetActive(true);
			objectRight.SetActive(true);
		}
	}
}
