using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour {

    RestartPointsManager restartPointsManager;
    SpriteRenderer sprRenderer;

    // Use this for initialization
    void Start() {
        restartPointsManager = GameObject.Find("Manager").GetComponent<RestartPointsManager>();
        if(restartPointsManager == null)
        {
            Debug.LogError("RestartPointsManager nie został znaleziony");
        }
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) // Jeżeli najdziemy naszą postacią na RestartPoint to przy tym punkcie się odrodzimy 
    {
        if(other.gameObject.tag == "Player")
        {
            restartPointsManager.UpdateStartPoint(this.gameObject.transform);
            sprRenderer.color = new Color(0.3f, 0.6f, 0.6f);
        }
    }
}
