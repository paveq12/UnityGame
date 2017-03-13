using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour {

    public Transform cameraTransform;
    // Współczynnik paralaxy
    public float parallaxFactory;

    // Różnice przesunięcia kamery
    private Vector3 prevCameraPosition;
    private Vector3 deltaCameraPosition;

	// Use this for initialization
	void Start () {

        prevCameraPosition = cameraTransform.position;

	}
	
	// Update is called once per frame
	void Update () {
        // Różnica między bierzącą pozycją kamery a poprzednią
        deltaCameraPosition = cameraTransform.position - prevCameraPosition;
        Vector3 parallaxPosition = new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactory), transform.position.y, transform.position.x);
        transform.position = parallaxPosition;
        prevCameraPosition = cameraTransform.position;

    }
}
