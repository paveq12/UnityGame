using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D other){ // Jeżeli wejdziemy w obiek bohaterem to się usunie
        if (other.gameObject.name == "Player"){
            Destroy(this.gameObject);
        }
    }
}
