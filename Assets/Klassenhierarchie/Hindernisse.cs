using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse soll alles rund um die Hindernisse im Level programmiert werden.
   - es werden verschiedene Arten von Hindernissen in unterschiedlichen Formen, bestehend aus kleinen Modulationen erzeugt
   - Hindernisse werden zufällig  im Level auf der akutellen Spielfläche generiert und platziert
   - das Spielfeld wird jedes Mal nach dem Aufruf den Funktion RotationHorizontal() oder RotationVertikal() in der Klasse CubeSteuerung neu generiert
   - Hindernisse bewegen sich auf die Spielfigur zu
*/

public class Hindernisse : MonoBehaviour {

	//eventuelle Array Organisation für die zeitgleiche Steuerung der Hindernisse notwendig!!!


	// Skript startet ab dem Beginn des Levels. 
	
	void Start () {
	
	// Erstes Spielfeld wird generiert. Funktionsaufruf FeldGenerieren()
			
	}
	
	void Baumstamm (){
	
	// Erzeugung eines GameObjekts 

	//Speicherung und Zuweisung des Objekts in Form des vormodellierten Baums
	
	}
	
	void Ball (){
	
	// Erzeugung eines GameObjekts 

	//Speicherung und Zuweisung des Objekts in Form des vormodellierten Balls
	}
	
	void QuietscheEnte (){
	
	// Erzeugung eines GameObjekts 

	//Speicherung und Zuweisung des Objekts in Form der vormodellierten QuietscheEnte
	
	}
	
	void Schiffchen (){
	
	// Erzeugung eines GameObjekts 

	//Speicherung und Zuweisung des Objekts in Form des vormodellierten Schiffchens
	
	}
		
	
	void FeldGenerieren() {
	
	// Initialisieren der Variable KoordinatenLaenge
	
	// Initialisieren der Variable KoordinatenBreite
	
	// Initialisieren der Variable objektArt mit Zufallszahlen zwischen 0 und 3 (4 Optionen!)
	
	// zufällige Auswahl der Objektart des Hindernisses mit SwitchCase
	
		// wenn objektArt == 0,
			//dann Baumstamm()
			
		// wenn objektArt == 1,
			//dann Ball()
			
		// wenn objektArt == 2,
			//dann QuietscheEnte()
			
		// wenn objektArt == 3,
			//dann Schiffchen()
	
	// zufällige Positionierung des Objektes in dem Feld zwischen 0 und KoordinatenBreite 
	
	// zufällige Positionierung des Objekts in dem Feld zwischen 0 und KoordinatenLaenge
	
	// Speicherung der aktuellen Objektposition für Kollision() in der Klasse SpielUeberwachung
	
	// Aufruf der Funktion Bewegung(hindernis)
	
	}
	
	// Beschreibung der Bewegung der Hindernisse
	
	void Bewegung (/* GameObject hindernis */) {
	
	// Start der Bewegung 
	
	// Bewegung des Hindernisses auf Spielfigur zu (z-Achse)
	
	// Definition der Geschwindigkeit

	
	}
	
	// Update is called once per frame
	
	void Update () {
	
	// Aufruf der Funktion FeldGenerieren() sobald Aufruf Funktion RotationHorizontal() oder RotationVertikal() in Klasse CubeSteuerung
	
	// solange Aufruf der Funktion Bewegung(GameObject hindernis) aller Hindernisse um Hindernisse zu bewegen, bis Kollision() in SpielUeberwachung oder Spielmodus auf false
		//dies eventuell in der Funktion Bewegung
	
	}
}
