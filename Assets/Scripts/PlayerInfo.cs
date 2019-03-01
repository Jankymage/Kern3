using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script voor het bijhouden van info van de player

public class PlayerInfo : MonoBehaviour {

	//voor de locatie van de speler
	//1 = Start
	//2 = Tree
	//3 = Communication
	//4 = Pollen
	//5 = Suckers
	public int playerLocation = 1;

	//voor de staat van het spel
	//1 = nothing happend yet
	//2 = suckers active
	//3 = pollen minder
	public int gameState = 1;


}
