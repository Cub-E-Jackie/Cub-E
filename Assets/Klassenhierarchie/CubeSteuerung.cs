using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse wird alles rund um den Cube und dessen Steuerung, Aussehen und Bewegungen programmiert.
   - Cube wird erzeugt 
   - das Rotationsverhalten definiert
   - das Rotationsverhalten wird gesteuert
*/

public class CubeSteuerung : MonoBehaviour {

	// globale Variable rotationszeit (float)
	// globale Variable drehrichtung (int)

	// Beim Start des Programms soll der Cube sofort erzeugt werden und im Hintergrund sichtbar sein.
	
	void Start () {
	
		//Erzeugung des Cube, nicht per Code erzeugen, also als primitiver Körper in Unity
		
		//Hinzufügen der Wasseroberfläche
		
	}
	
	// Rotationsverhalten steuern
	
	void Drehverhalten (){
	
		// Initialisieren von rotationszeit mit Zufallszahlen zwischen 0.25 und 0.5 Minuten  
		
		// Initialisieren von drehrichtung mit Zufallszahlen zwischen und einschließlich 0 und 3 (vier Möglichkeiten!)
		
		// Zurücklaufen der Zeit auf 0 initialisieren -> in die Update Methode!!!
		
		
		// wenn rotationszeit == 0,
		
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
	
		// Spielmodus auf false, zur Organisation von SpielerInput
	
		// Cube dreht sich vertikal um x Achse um übergebenen Winkel 
		
		// Spielmodus auf true, zur Organisation von SpielerInput
		
	}
	
	//Rotationsbewegung nach links oder rechts programmieren
	
	void RotationHorizontal (float richtung){
	
		// Cube dreht sich horizontal um y Achse um übergebenen Winkel 
		
	}
	
	
	// Update in bestimmten Zeitabständen während des Spiels
	
	void Update () {
		
		// solange Spielmodus auf true ist, rufe Funktion Drehverhalten() auf
		
	}
}
