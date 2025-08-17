using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{
    public float geschwindigkeit = 9.0f;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey("up")){
     transform.Translate(Vector2.up*Time.deltaTime*geschwindigkeit);
     }
     if(Input.GetKey("down")){
     transform.Translate(Vector2.down*Time.deltaTime*geschwindigkeit);
     }
     if(Input.GetKey("left")){
     transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);
     spriteRenderer.flipX = false;
    }
    if(Input.GetKey("right")){
     transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);
     spriteRenderer.flipX = true;

    }

    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player"){
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }
}
