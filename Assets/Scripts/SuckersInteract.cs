using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script voor interactie met suckers
//checked of game state 1 is
//checked of speler in sucker area is
//zet suckers aan

public class SuckersInteract : MonoBehaviour {

	public PlayerInfo playerInfo;

	//checked of er op het object geklikt word
	void OnMouseDown(){
		
		if(playerInfo.playerLocation == 5 && playerInfo.gameState == 1){
			//Debug.Log(playerInfo.gameState);
			playerInfo.gameState = 2;
			//Debug.Log(playerInfo.gameState);
			//zet image slacking suckers deactief 
			//zet image active suckers actief
		}



	}


}
