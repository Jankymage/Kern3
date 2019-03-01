using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if clicked
//checked locatie van speler
//animate player from A tot B or B to A 
//past de locatie van de speler aan in info

public class BorderPollenSuckers : MonoBehaviour {

	//voor de animatie/verplaatsing
	public Animator playerMovement;

	//word gebruikt om locatie an de speler bij te houden.
	public PlayerInfo PlayerInfo;

	void Update(){
		
	}

	//checked of er op het object geklikt word
	void OnMouseDown(){
		
		//checked of speler in Pollen (4) is
		//zo ja, animeer naar Suckers (5)
		if(PlayerInfo.playerLocation == 4){
			Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("PollenToSuckers");
			PlayerInfo.playerLocation = 5;
		}	

		//checked of speler in Suckers (5) is
		//zo ja, animeer naar Pollen (4)
		else if(PlayerInfo.playerLocation == 5){
			Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("SuckersToPollen");
			PlayerInfo.playerLocation = 4;
		}



	}

}
