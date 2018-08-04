using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //braucht man um die verschiedenen Level zu koordinieren

public class Startmenue : MonoBehaviour {

	// Start Game:
	public void PlayGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // immer ein Level addieren, erst Level eins, dann zwei... bzw. man kommt zum Spiel 
		//ACHTUNG!!!: Spiel und Menü müssen miteinander verbunden werden! wie? Tutorial: "START MENU in Unity" auf YouTube
		
	}
	
	// Quit Game:
	public void  QuitGame() {
		Debug.Log("QUIT"); //Info wird geschrieben
		Application.Quit(); //Beendet Spiel
	}
}
