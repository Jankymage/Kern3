using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script voor interactie met suckers
//checked of game state 2 is
//checked of speler in pollen area is
//zet verminder pollen

public class PollenInteract : MonoBehaviour {

	public PlayerInfo playerInfo;
	//public GameObject pollenBalance;
	public GameObject cloudHalf;
	public GameObject cloudFinish;
	public GameObject CommStart;
	public GameObject CommFinish;

	//checked of er op het object geklikt word
	void OnMouseDown(){
		

		if(playerInfo.playerLocation == 4 && playerInfo.gameState == 2){
	
			playerInfo.gameState = 3;

			//zet image over actieve pollen deactief 
			//zet image normale pollen actief
			
			cloudHalf.SetActive(false);
			cloudFinish.SetActive(true);

			CommStart.SetActive(false);
			CommFinish.SetActive(true);


		}



	}


}
