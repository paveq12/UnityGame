using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float heroSpeed;
    Animator anim;
    bool dirToRight = true;
    Rigidbody2D rgdBody;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (horizontalMove < 0 && dirToRight)
        {
            Flip();
        }
        if (horizontalMove > 0 && !dirToRight)
        {
            Flip();
        }
	}

    void Flip ()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
}
