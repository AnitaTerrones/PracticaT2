using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGoldController : MonoBehaviour
{
    private GameController gameCoinsG;
    private const int LAYER_GOLD = 7;

    void Start()
    {
        gameCoinsG =FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag ("Player") && this.gameObject.layer == LAYER_GOLD)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameCoinsG.PlusCoinsGold(4);
            Debug.Log(gameCoinsG.GetCoinsGold());

        }
    }
}

