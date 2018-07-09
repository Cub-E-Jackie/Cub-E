using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse werden die organisatorischen Dinge sozusagen aus dem Hintergrund  geregelt.
   - globale Variablen zur Verwaltung des Spiels generiert und verwaltet
   - die Größen aus dem Menü werden implementiert und verwaltet
   - das Menü selbst wird gesteuert mithilfe von globalen Variablen
   - das Spiel wird beendet und gestartet
   - die Spielzeit wird hier in einer Variable gespeichert und verwaltet

*/

public class SpielUeberwachung : MonoBehaviour {

// globale Variable zur Speicherung der Anzahl Leben (int)-> public für Klassen UIverwaltung, HIndernisse
// globale Variable zur Speicherung der Spielzeit(float) -> public für Klasse UIverwaltung
// globale Variable zur Verwaltung des Spielmodus (bool)-> public für Klassen UIverwaltung, SpielerInput, CameraSteuerung, HIndernisse

	// Start der Klasse ab Beginn des Programms, dies ist die erste Klasse!!!
	void Start () {
	
	// Initialisieren von den globalen Variablen
	
	// Menü Interface erzeugen und positionieren
	
	//Initialisieren bei Starten des Spiels durch Intialisierung des Menüs
	
	//Aufruf der Funktion LevelAnzeige
	
	//Aufruf der Funktion AnzahlLeben 
	
		
	}
	
	void Kollision(){
	
	
	}
	
	
	void GameOver (){
	// if Leben auf 0
	// Aufruf UIverwaltung Methode GameOverMenüErzeugen(); oder eine Klasse, wenn für jedes Menü eine Klasse
	//setzen der Variable Spielmodus auf false
	
	// wenn Zeit auf ... dann Spielabbruch und erzeugen des GameObjects Overmenü
	}
	
	void SpielStart(){
	// ???
	}
	
	void LevelAnzeige (){
	
	//Gameobjekt erzeugen welches aktuelles Level anzeigt, ab Beginn des Levels
	
	
	}
	
	void AnzahlLeben (float leben){
	
	//Teil des UI!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	
	//Zugriff auf UI
	
	//GameObjekt Leben als kleinen Würfel erstellen, so oft wie leben Variable
	
	// globale Variable!!! zur Speicherung der Leben, leben - oder + 1
	
	//Gameobjekt erzeugen welche Leben in Menü anzeigt, evtl. rekursiver Methodenaufruf, um so viele Lebenswürfel zu erzeugen
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	// wenn Spieler Kollision mit Hindernis AnzahlLeben(-1)
	
	// wenn Spieler Kollision mit Stern oder ähnlichem AnzahlLeben(+1)
	
	//Starten des Spiels und des Levels hier, also Aufruf der Klassen
	
	// Anschließend Aufruf von SpielStart()
	
	// Messen der Spielzeit, speichern der Zeit in fester und globaler Variable
	
	//deaktivieren der verschiedenen Canvas objekte!!! zur Verwaltung von den verschiedenen Menü-Variationen!!!
	
	}
}
