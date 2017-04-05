using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CounterController : MonoBehaviour {

    int numberOfBoxes;
    public Text counterView;

	// Use this for initialization
	void Start () {
        ResetCounter();
	}
	
	public void IncrementCounter()
    {
        numberOfBoxes++;
        counterView.text = numberOfBoxes.ToString();
    }
    public void ResetCounter() // Resetowanie licznika punktów po starcie gry
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
