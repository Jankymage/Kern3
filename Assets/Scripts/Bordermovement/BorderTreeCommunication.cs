using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if clicked
//checked locatie van speler
//animate player from A tot B or B to A 
//past de locatie van de speler aan in info

public class BorderTreeCommunication : MonoBehaviour {


	//voor de animatie/verplaatsing
	public Animator playerMovement;

	//word gebruikt om locatie an de speler bij te houden.
	public PlayerInfo PlayerInfo;

	void Update(){
		
	}

	//checked of er op het object geklikt word
	void OnMouseDown(){
		
		//checked of speler in Tree (2) is
		//zo ja, animeer naar Communication (3)
		if(PlayerInfo.playerLocation == 2){
			//Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("TreeToCommunication");
			PlayerInfo.playerLocation = 3;
		}	

		//checked of speler in Communication (3) is
		//zo ja, animeer naar Tree (2)
		else if(PlayerInfo.playerLocation == 3){
			//Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("CommunicationToTree");
			PlayerInfo.playerLocation = 2;
		}



	}

}
