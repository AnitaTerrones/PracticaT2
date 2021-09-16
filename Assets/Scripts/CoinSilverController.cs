using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSilverController : MonoBehaviour
{
    private GameController gameCoinsS;
    
    private const int LAYER_SILVER = 8;

    void Start()
    {
        gameCoinsS =FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag ("Player")&&this.gameObject.layer == LAYER_SILVER)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameCoinsS.PlusCoinsSilver(2);
            Debug.Log(gameCoinsS.GetCoinsSilver());
        }
    }
}