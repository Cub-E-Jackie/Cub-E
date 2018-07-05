using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse werden die organisatorischen Dinge aus dem Hintergrund sozusagen geregelt. Außerdem werden hier die Größen aus dem Menü implementiert und verwaltet.
   Unteranderem wird hier das Level angezeigt und verwaltet und die Leben des Spielers verwaltet. Außerdem wird hier das Spiel unter bestimmten Voraussetzungen gestartet und das Spiel abgebrochen!

*/

public class SpielUeberwachung : MonoBehaviour {

//globale Variable zur Speicherung der Anzahl Leben, Initialisieren auf 5
// globale Variable zur Speicherung der Spielzeit auf 0

//globale Variable public gameobject UI_Lebensbalken, jetzt zugriff im skript möglich

	// Use this for initialization
	void Start () {
	
	//Menü Interface erzeugen und positionieren
	
	//Initialisieren bei Starten des Spiels durch Intialisierung des Menüs
	
	//Aufruf der Funktion LevelAnzeige
	
	//Aufruf der Funktion AnzahlLeben 
	
		
	}
	
	void GameOver (){
	// wenn Leben auf 0 dann Spielabbruch und erzeugen des GameObjects Overmenü
	
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
