using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieli : MonoBehaviour
{
    public float geschwindigkeit = 5.0f;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey("w")){
     transform.Translate(Vector2.up*Time.deltaTime*geschwindigkeit);
     }
     if(Input.GetKey("s")){
     transform.Translate(Vector2.down*Time.deltaTime*geschwindigkeit);
     }
     if(Input.GetKey("a")){
     transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);
     spriteRenderer.flipX = false;
    }
    if(Input.GetKey("d")){
     transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);
     spriteRenderer.flipX = true;
    }
        
    }
    
        
    }

