using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingHero : MonoBehaviour {

    public GameObject hero;
    public float smooth;

    private Vector3 currVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Podążanie za bohaterem tylko w osi x
        Vector3 newCameraPosition = new Vector3(hero.transform.position.x, transform.position.y, transform.position.z);
        // Dodanie SmoothDamp czyli płynne podążanie kamery
        transform.position = Vector3.SmoothDamp(transform.position, newCameraPosition, ref currVelocity, smooth);
		
	}
}
