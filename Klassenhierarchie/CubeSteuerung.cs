using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse wird alles rund um den Cube programmiert.
   - Cube wird erzeugt 
   - das Rotationsverhalten gesteuert
   - das Rotationsverhalten definiert
 */

public class CubeSteuerung : MonoBehaviour {

	// Variable drehrichtung (private, int)

	// Beim Start des Programms soll der Cube sofort erzeugt werden und im Hintergrund sichtbar sein.
	void Start () {
	
		//Erzeugung des Cube, nicht per Code erzeugen, also als primitiver Körper in Unity
		
		//Hinzufügen der Wasseroberfläche
		
	}
	
	// Rotationsverhalten definiert
	/* 
	Funktionsaufruf durch die Methode Kollision() in Klasse Hindernisse,
	globale Variable kollision aus SpielUeberwachung auf true
	*/
	void CubeDrehen (){
	 
		
		// Initialisieren von drehrichtung mit Zufallszahlen zwischen und einschließlich 0 und 3 (vier Möglichkeiten!)
			
		//Auswahl der Rotationsrichtung mit SwitchCase
			
			// wenn drehrichtung == 0, 
				//dann RotationHorizontal(float richtung);
				
			// wenn drehrichtung == 1, 
				//dann RotationHorizontal(float - richtung);
			
			// wenn drehrichtung == 2, 
				//dann RotationVertikal(float richtung);
			
			// wenn drehrichtung == 3, 
				//dann RotationVertikal(float - richtung);
				
	}
	
	//Rotationsbewegung nach oben oder unten programmieren
	void RotationVertikal (float richtung){
	
		// globale Variable aktivModus auf false, zur Organisation von SpielerInput
	
		// Cube dreht sich vertikal um x Achse um übergebenen Winkel 
		
		// Funktionsaufruf ErzeugeHindernis() der Klasse Hindernisse
		
		// globale Variable aktivModus auf true, zur Organisation von SpielerInput
		
	}
	
	//Rotationsbewegung nach links oder rechts programmieren
	void RotationHorizontal (float richtung){
	
		// globale Variable aktivModus auf false, zur Organisation von SpielerInput
	
		// Cube dreht sich horizontal um y Achse um übergebenen Winkel 
		
		// Funktionsaufruf Feldgenerieren() der Klasse Hindernisse
		
		// globale Variable aktivModus auf true, zur Organisation von SpielerInput
		
	}
	
	
	// Update in bestimmten Zeitabständen während des Spiels, nicht nötig da externer Funktionsaufruf der Bewegung
	void Update () {
		
		
	}
}
