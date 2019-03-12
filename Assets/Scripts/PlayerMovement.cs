using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {


	//voor de knoppen
	public Button buttonLeft;
	public Button buttonRight;

	//voor de animatie/verplaatsing
	public Animator playerMovement;

	//word gebruikt om locatie an de speler bij te houden.
	public PlayerInfo PlayerInfo;

	// Use this for initialization
	void Start () {
		//om de knopen te initialiseren
		buttonLeft.onClick.AddListener(MoveLeft);
		buttonRight.onClick.AddListener(MoveRight);
	}


//if clicked
//check PlayerInfo.playerLocation
//play right animation


	void MoveLeft(){
		if(PlayerInfo.playerLocation == 1){
			playerMovement.Play("StartToTree");
			PlayerInfo.playerLocation = 2;
		}
		
		else if(PlayerInfo.playerLocation == 2){
			playerMovement.Play("TreeToCommunication");
			PlayerInfo.playerLocation = 3;
		}

		else if(PlayerInfo.playerLocation == 3){
			playerMovement.Play("CommunicationToPollen");
			PlayerInfo.playerLocation = 4;
		}

		else if(PlayerInfo.playerLocation == 4){
			playerMovement.Play("PollenToSuckers");
			PlayerInfo.playerLocation = 5;
		}

	}

	void MoveRight(){

		if(PlayerInfo.playerLocation == 5){
			playerMovement.Play("SuckersToPollen");
			PlayerInfo.playerLocation = 4;
		}
		
		else if(PlayerInfo.playerLocation == 4){
			playerMovement.Play("PollenToCommunication");
			PlayerInfo.playerLocation = 3;
		}

		else if(PlayerInfo.playerLocation == 3){
			playerMovement.Play("CommunicationToTree");
			PlayerInfo.playerLocation = 2;
		}

		else if(PlayerInfo.playerLocation == 2){
			playerMovement.Play("TreeToStart");
			PlayerInfo.playerLocation = 1;
		}

	}

}
