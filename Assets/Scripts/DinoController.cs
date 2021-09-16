using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
   private Rigidbody2D rb;
    private SpriteRenderer sr;

    public float velocityX = 1;

    private const int LAYER_COLISION = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
         rb.velocity = new Vector2(-velocityX, rb.velocity.y); 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LAYER_COLISION)
        {
            rb.velocity = new Vector2(velocityX, rb.velocity.y);
            sr.flipX = false;
        }
        if (collision.gameObject.layer == LAYER_COLISION)
        {
            rb.velocity = new Vector2(-velocityX, rb.velocity.y);
            sr.flipX = true;
        }
    }
}
