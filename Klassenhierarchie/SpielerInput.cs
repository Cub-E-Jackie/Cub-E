using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  In dieser Klasse wird die Steuerung des Spiels definiert und verwaltet.
  - die Steuerung WÄHREND des Levels
  - die Steuerung des Spielers in horizontaler Richtung, nach links und rechts
  - abhängig von Spielmodus
  - Kollision abfangen und entsprechend andere Funktionen aufrufen
  
*/

public class SpielerInput : MonoBehaviour {

	// Start des Skriptes ab Start des Levels
	void Start () {
	
	//Spieler als Objekt mit vormodelierter Form generieren
	
	//Positionierung des Spielers im Feld
		
	}
	
	void BewegungSpieler (float richtungSpieler){
	
	//translation des Spieler Objekts um die float zahl die übergeben wurde
	
	// Bewegung stoppen, wenn Grenze des Felds erreicht
	
	
	}
	
	// Hier kommt der Trigger und Collider Teil zum realisieren der Kollisionen und zum abfangen der Ereignisse!
    void OnTriggerEnter(Collider other)
    {
		// wenn other == Schiffchen, Baumstamm ODER Ball ist, dann:
		
			// aktivModus auf false
			
			// leben - 1
			
			// Funbktionsaufruf von AnzahlLeben(leben) in Klasse UIverwaltung
			
			// Funbktionsaufruf von CameraZurueck() in Klasse CameraSteuerung
			
			// Funbktionsaufruf von CubeDrehen() in Klasse CubeSteuerung 
			
			// Funktionsaufruf von Feldwechsel() in Klasse Hindernisse
		
		// wenn other == QuietscheEnte, dann:
		
			// fortschritt + 1
			
			// Funbktionsaufruf von AnzahlFortschritt(fortschritt) in Klasse UIverwaltung
			
			// Zerstörung von diesem QuietscheEnte-Objekt -> Destroy(GameObject other);

    }

	
	
	void Update () {
		
	// Solange aktivModus auf true
	
		//Spieler bei Tastenbedienung A Aufruf der Funktion BewegungSpieler(negative floatzahl)
	
		//Spieler bei Tastenbedienung D Aufruf der Funktion BewegungSpieler(positive floatzahl)
	
	
	}
}
