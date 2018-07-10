using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredEvent : MonoBehaviour {

    public float lifetime = 10f;
    private float timer = 0;
	
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            Destroy(this.gameObject);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
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


}
