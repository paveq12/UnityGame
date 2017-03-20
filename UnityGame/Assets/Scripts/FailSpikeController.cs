using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailSpikeController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	// Metoda zostanie wywołana jeśli jakiś obiekt wejdzie w kolizje z kolcami
	void OnTriggerEnter2D (Collider2D other)
    {   
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
        }
    }
}
