using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
In dieser Klasse wird alles rund um den Cube und dessen Steuerung, Aussehen und Bewegungen programmiert.
Unteranderem wird hier der Cube erzeugt und das Rotationsverhalten definiert.
*/

public class CubeSteuerung : MonoBehaviour {

	// Beim Start des Spiels soll der Cube sofort erzeugt werden und im Hintergrund sichtbar sein.
	
	void Start () {
	
		//Erzeugung des Cube
		
		//Hinzufügen der Wasseroberfläche
		
	}
	
	//Rotationsbewegung programmieren
	
	void RotationVertikal (float richtung){
	
		// Cube dreht sich vertikal um x Achse um übergebenen Winkel 
		
	}
	
	//Rotationsbewegung programmieren
	
	void RotationHorizontal (float richtung){
	
		// Cube dreht sich vertikal um y Achse um übergebenen Winkel 
		
	}
	
	// Update in bestimmten Zeitabständen während des Spiels
	
	void Update () {
		/*
		
		 wenn eine bestimmte, zufällig bestimmte Zeit (z.B. zwischen 0.25 und 0.5 Minuten) abgelaufen ist, dann dreht der Cube sich automatisch
		 in eine beliebige Richtung
		
		if zufallszahl == 0, dann
		Aufruf drehen Methode mit zufälliger Richtung
		
		*/
	}
}
