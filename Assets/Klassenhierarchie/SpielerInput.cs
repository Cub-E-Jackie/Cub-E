using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  In dieser Klasse wird die Steuerung des Spiels definiert und verwaltet.
  - die Steuerung WÄHREND des Levels
  - die Steuerung des Spielers in horizontaler Richtung, nach links und rechts
  - abhängig von Spielmodus
  
  Sowohl bei Spielvariante A, als auch bei B: Steurung der Spielfigur nach links oder rechts.
*/

public class SpielerInput : MonoBehaviour {

	// Start des Skriptes ab Start des Levels
	
	void Start () {
	
	//Spieler als Objekt mit vormodelierter Form generieren
	
	//Positionierung des Spielers im Feld
	
	//Speicherung der Position des Spielers in Variablen
	
	}
	
	void BewegungSpieler (float richtungSpieler){
	
	//translation des Spieler Objekts um die float zahl die übergeben wurde
	
	// Bewegung stoppen, wenn Grenze des Felds erreicht oder Kollision() in SpielUeberwachung aufgerufen wird
	
	
	}
	
	
	void Update () {
	
	//Spieler bei Aufruf der gesamten Klasse nochmal neu, ab Start()
	
	// Solange Spielmodus auf true
	
		//Spieler bei Tastenbedienung A Aufruf der Funktion BewegungSpieler(negative floatzahl)
	
		//Spieler bei Tastenbedienung D Aufruf der Funktion BewegungSpieler(positive floatzahl)
	
	
	}
}
