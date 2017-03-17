using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailSpikeController : MonoBehaviour {

    public Transform startPoint;

	// Use this for initialization
	void Start () {
		
	}
	// Metoda zostanie wywołana jeśli jakiś obiekt wejdzie w kolizje z kolcami
	void OnTriggerEnter2D (Collider2D other)
    {   // Jeżeli ktoś wejdzie w kolce to zostanie przeniesiony do pozycji startowej
        if (other.gameObject.name == "Player")
        {
            other.transform.position = startPoint.position;
        }
    }
}
