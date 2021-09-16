using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float velocityX = 10;

    private Rigidbody2D rb;
    private GameController gameBullet;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameBullet =FindObjectOfType<GameController>();
        Destroy(this.gameObject,2);//destruimos balita
    }

    void Update()
    {
        //cambiamos velocidad en X
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player")
            Destroy(this.gameObject);
       
        if(other.CompareTag ("Enemy"))
        {
            Destroy(other.gameObject);
            gameBullet.PlusScore(10);
            Debug.Log(gameBullet.GetScore());
        }
    }
}
