using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float horizontalMove = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
		
	}
}
