using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour {

    CounterController counterController;
    public AudioClip clip;

	// Use this for initialization
	void Start () {

        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("CounterController nie zostal znaleziony.");
        }
	}

    void OnTriggerEnter2D(Collider2D other){ // Jeżeli wejdziemy w obiek bohaterem to się usunie
        if (other.gameObject.name == "Player"){
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            counterController.IncrementCounter(); // Wywołanie metody do dodania punktów
        }
    }
}
