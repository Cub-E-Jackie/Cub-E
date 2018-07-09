using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Hier werden die canvas Objekte der vier verschiedenen Menüs angesprochen und aktiviert und deaktiviert.
//rechtsKlick auf Hierarchie Feld UI Canvas erzeugen, Scrollbar etc. hinzufügen und im Menü bearbeiten und verschieben
// ansprechen durch globale Variable im Skript, siehe SpielÜberwachung Lebensbalken, analog dazu

// hier wird nun gezeigt wie aktivieren und deaktivieren der einzelnen Menü Canvas Objekte geht

// es gibt: Startmenü, Levelmenü, Sieger Menü und Game Over Menü

public class UIverwaltung : MonoBehaviour {

	public int counter = 0; 
	//Arbeit mit bollschen Variablen passend und praktisch
	
	private bool layer2 = false;
	
	//zur einfachen Gestaltung des Menüs, und das ist wirklich einfach im Menü von Unitiy 
	public GUIStyle guiStyle; 

	void OnGUI()
	{
		// Achtung Arbeit im 2d Bereich, also hier ein quadrat kein würfel
		//Rect rct = new Rect(20, 20, 200, 50);
		
		//GUI.TextField(new Rect(20, 20, 200, 50), "Hello World!");
		//GUI.Button (rct, "Push");
		
		/*if (GUI.Button(rct, "+1"))
		{
		Erhoehe();
		}
		*/
		if (GUI.Button (new Rect (20, 20, 200, 30), "Zeige/Verstecke")){
		
		layer2 = !layer2; 
		}
		
		if (layer2){
		
		// Rect (a, b, A, B)," bla");
		//a und b sind die Positionen a senkrecht und b waagrecht
		// A und B sind die Größen des Rechtecks A breite B 
		
		GUI.TextField( new Rect(20, 20, 200, 500), "Hier ist der Test!");
		GUI.TextField( new Rect(20, 20, 200, 50), "Noch eins");
		
		}
		
	}
	/*
	void Erhoehe(){
	
	}
	*/
}
