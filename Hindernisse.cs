using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   In dieser Klasse soll alles rund um die Hindernisse im Level programmiert werden.
   - es werden verschiedene Arten von Hindernissen in unterschiedlichen Formen, bestehend aus kleinen Modulationen definiert
   - es gibt zwei Arten von Hindernissen, "gute" und "schlechte" Hindernisse -> eine erhöhen den Fortschritt, andere verringern die Leben
   - Hindernisse werden zufällig  im Level auf der akutellen Spielfläche generiert und platziert
   - Hindernisse bewegen sich auf die Spielfigur zu
*/

public class Hindernisse : MonoBehaviour {
	
	/*
	Skript von Herr Pattmann zur Erzeugung eines Hindernisses und Trigger abfangen (TriggerEvent) ergänzt
	
	// globale Variablen
    public GameObject hindernis;
    private float timeCounter = 0f;
	public float lifetime = 10f;
    private float timer = 0;
	
	private int objektArt;

	// Initialisierung der Klasse
	void Start () {
		
		// Funktionsaufruf FeldGenerieren() beim Start des Levels, 
		
	}
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime;
        if (timeCounter > 1f)
        {
            timeCounter = 0f;
            ErzeugeHindernis();
        }
	}


    private void ErzeugeHindernis()
    {
        Vector3 startPoint = new Vector3(Random.Range(-5f, 5), 10f, Random.Range(-5f, 5f));
        Instantiate(hindernis, startPoint, Quaternion.identity);
    } 
	
	*/
	 
	/* 
	Hier kommt der Trigger und Collider Teil zum realisieren der Kollisionen und zum abfangen der Ereignisse!
	
    void OnTriggerEnter(Collider other)
    {
        // ab hier schon abfangen 

		// Art des Colliders = schlecht (Baumstamm, Ball oder Schiffchen) => Funktionsaufruf Kollision()
		
		// Art des Colliders = gut (QuietscheEnte) => Funktionsaufruf Fortschritt()

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
	*/
	 
	void Baumstamm (){
	
	// Erzeugung eines GameObjekts 
	
	// Vector3 startPoint = new Vector3(Random.Range(-5f, 5), 10f, Random.Range(-5f, 5f));
	// Instantiate(hindernis, startPoint, Quaternion.identity);

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
		
	/*das Spielfeld wird jedes Mal nach dem Aufruf den Funktion RotationHorizontal() oder RotationVertikal() 
	in der Klasse CubeSteuerung neu generiert*/
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
	
	/*
		
	timer += Time.deltaTime;
	
	if (timer > lifetime){
	
	Destroy(this.GameObject);
	
	}
	*/
	
		
	// timeCounter += Time.deltaTime;
	
	// wenn timeCounter > 1f)
		// dann timeCounter = 0f;
		// ErzeugeHindernis();
		
	
	// Aufruf der Funktion FeldGenerieren() sobald Aufruf Funktion RotationHorizontal() oder RotationVertikal() in Klasse CubeSteuerung
	
	// solange Aufruf der Funktion Bewegung(GameObject hindernis) aller Hindernisse um Hindernisse zu bewegen, bis Kollision() in SpielUeberwachung oder Spielmodus auf false
		//dies eventuell in der Funktion Bewegung
	
	}
}
