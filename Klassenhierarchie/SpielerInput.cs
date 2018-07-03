using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  In dieser Klasse wird die Steuerung des Spiels definiert und verwaltet.
  Dabei geht es vor allem um die Steuerung WÄHREND des Levels.
  
  Sowohl bei Spielvariante A, als auch bei B: Steurung der Spielfigur nach links oder rechts.
*/

public class SpielerInput : MonoBehaviour {

	// Start des Skriptes ab Start des Levels
	
	void Start () {
	
	//Spieler als Objekt mit vormodelierter Form generieren
	
	//Spieler bei Start des Levels auf Position bringen
		
	}
	
	void BewegungSpieler (float richtungSpieler){
	
	//translation des Spieler Objekts um die floatzahl die übergeben wurde
	
	//Stop Punkt wenn die Bewegung von der Spielfläche weg gehen würde und/Oder es eine Kollion mit einem Hinderniss entstehen würde
	
	
	}
	
	// Update is called once per frame
	
	void Update () {
	
	//Spieler bei Aufruf der Funktion rotation der Klasse CubeSteuerung neu positionieren
	
	//Spieler bei Tastenbedienung A Aufruf der Funktion BewegungSpieler(negative floatzahl)
	
	//Spieler bei Tastenbedienung D Aufruf der Funktion BewegungSpieler(positive floatzahl)
	
	
	}
}
