using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse soll alles rund um die Hindernisse im Level programmiert werden.
   Es gibt verschiedene Arten von Hindernissen in unterschiedlichen Formen, bestehend aus kleinen Modulationen.
   Die Hindernisse werden zufällig  im Level auf der akutellen Spielfläche generiert.
   Dabei wird das Spielfeld jedes Mal nach dem Aufruf der Funktion Rotation in der Klasse CubeSteuerung neu generiert.
   
   Spielvariante A: Die Figur bewegt sich in Richtung des Flusses, sprich auf die Hindernisse zu.
   
   Spielbariante B: Die Hindernisse bewegen sich auf die Spielfigur zu. 
*/

public class Hindernisse : MonoBehaviour {

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
	
	/*___________________________________________Variante B__________________________________________________*/
	
	
	void FeldGenerierenB() {
	
	// zufällige Auswahl der Objektart des Hindernisses
	
	// zufällige Positionierung des Objektes zu Beginn der Erzeugung und Generierung
	
	}
	
	// Beschreibung der Bewegung der Hindernisse
	
	void BewegungB (/* GameObject hindernis */) {
	
	// Start der Bewegung 
	
	// Bewegung des Hindernisses auf Spielfigur zu (z-Achse)
	
	// Definition der Geschwindigeit
	
	// Definition des Endpunktes der Bewegung, sprich bei Kollision mit Spielfigur und/Oder Ende des Spielfeldes	
	
	}
	
	/*___________________________________________Variante A_____________________________________________________*/
	
	void FeldGenerierenA() {
	
	// zufällige Auswahl der Objektart des Hindernisses
	
	// zufällige Positionierung des Objektes zu Beginn der Erzeugung und Generierung
	
	}
	
	// Beschreibung der Bewegung der Hindernisse, hier aber nicht auf Spielfigur zu sondern horizontale Bewegung auf Spielfeld
	
	void BewegungA (/* GameObject hindernis */) {
	
	// Start der Bewegung des Hindernisses in einem begrenztem Bereich!!!
	
	//Richtungswechsel, nach einer zufälligen Position
	
	// Definition der Geschwindigeit
	
	
	}
	
	// Update is called once per frame
	
	void Update () {
	
	//Aufruf der Funktion FeldGenerieren() sobald Aufruf Funktion rotation in Klasse CubeSteuerung
	
	//bei beiden Varianten! Aufruf der Funktion Bewegung (GameObject hindernis) um Hindernis zu bewegen
	}
}
