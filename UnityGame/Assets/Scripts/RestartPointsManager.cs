﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPointsManager : MonoBehaviour {

    public PlayerController playerController;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	public void UpdateStartPoint(Transform newTransform)
    {
        playerController.startPoint = newTransform;
    }
}
