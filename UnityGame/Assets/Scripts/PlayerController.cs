using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;
    public LayerMask layersToTest;
    public Transform startPoint;
    Animator anim;
    bool dirToRight = true;
    Rigidbody2D rgdBody;
    // odbijanie się tylko od gruntu
    private bool onTheGround;
    private float radius = 0.1f;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // Jeżeli stan animacji jest na spikeContact to wyjdzie z metody
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("spikeContact"))
        {
            rgdBody.velocity = Vector2.zero;
            return;
        }

        // Sprawdzanie czy jesteśmy na ziemii
        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layersToTest);

        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);

        // Skok postaci
        if(Input.GetKeyDown(KeyCode.Space) /*oraz tylko od obiektu*/ && onTheGround)
        {
            rgdBody.AddForce(new Vector2(0f, jumpForce));
            anim.SetTrigger("jump");
        }

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        // Poruszanie się postaci lewo/prawo
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

    public void RestartHero () // Jeżeli ktoś wejdzie w kolce to zostanie przeniesiony do pozycji startowej(metoda do zmiany pozycji)
    {
        gameObject.transform.position = startPoint.position;
    }
}
