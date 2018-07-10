using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementScript : MonoBehaviour {

    // globale Variablen
    public GameObject hindernis;

    private float timeCounter = 0f;

	// Use this for initialization
	void Start () {
		
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
}
