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

	//checked of er op het object geklikt word
	void OnMouseDown(){
		

		if(playerInfo.playerLocation == 4 && playerInfo.gameState == 2){
			//Debug.Log(playerInfo.gameState);
			playerInfo.gameState = 3;
			//Debug.Log(playerInfo.gameState);
			//zet image over actieve pollen deactief 
			//zet image normale pollen actief
			
			//pollenBalance.SetActive(true);
			
			cloudHalf.SetActive(false);
			cloudFinish.SetActive(true);

			
			//convetie?

		}



	}


}
