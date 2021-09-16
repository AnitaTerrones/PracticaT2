using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public float velocityX = 10;
    public float JumpForce = 40;

    public GameObject RightBullet;
    public GameObject LeftBullet;
    
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;


    //private GameController game;
    
    private const int ANIMATION_IDLE = 0;
    private const int ANIMATION_RUN = 1;
    private const int ANIMATION_SLIDE = 2;
    private const int ANIMATION_JUMP = 3;

    void Start()
    {
        Debug.Log("Iniciando Game Objet");//mensaje en consola

        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //empieza quieto
        rb.velocity =  new Vector2(0,rb.velocity.y);
        changeAnimation(ANIMATION_IDLE);

        //Ir derecha
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(velocityX, rb.velocity.y);
            sr.flipX = false;
            changeAnimation(ANIMATION_RUN);
        }

        //Ir izquierda
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-velocityX, rb.velocity.y);
            sr.flipX = true;
            changeAnimation(ANIMATION_RUN);
        }
        //disparar
        if (Input.GetKeyUp(KeyCode.X))
        {
            var Bullet = sr.flipX ? LeftBullet : RightBullet;
            var Position = new Vector2(transform.position.x, transform.position.y);
            var Rotation = RightBullet.transform.rotation;
            Instantiate(Bullet, Position, Rotation);
        }

        //Deslizar
        if(Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(velocityX, rb.velocity.y);
            changeAnimation(ANIMATION_SLIDE);
        }

        //Salta
        if(Input.GetKeyUp(KeyCode.Space) )
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            changeAnimation(ANIMATION_JUMP);
        }
    }

    
    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}


