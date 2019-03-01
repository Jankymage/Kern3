using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if clicked
//checked locatie van speler
//animate player from A tot B or B to A 
//past de locatie van de speler aan in info


public class BorderStartTree : MonoBehaviour {


	//voor de animatie/verplaatsing
	public Animator playerMovement;

	//word gebruikt om locatie an de speler bij te houden.
	public PlayerInfo PlayerInfo;

	void Update(){
		
	}

	//checked of er op het object geklikt word
	void OnMouseDown(){
		
		//checked of speler in start is
		//zo ja, animeer naar tree
		if(PlayerInfo.playerLocation == 1){
			Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("StartToTree");
			PlayerInfo.playerLocation = 2;
		}	

		//checked of speler in Tree is
		//zo ja, animeer naar Start
		else if(PlayerInfo.playerLocation == 2){
			Debug.Log(PlayerInfo.playerLocation);
			playerMovement.Play("TreeToStart");
			PlayerInfo.playerLocation = 1;
		}



	}

}
