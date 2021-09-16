using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBronzeController : MonoBehaviour
{
    private GameController gameCoinsB;
    private const int LAYER_BRONZE = 9;

    void Start()
    {
        gameCoinsB =FindObjectOfType<GameController>();
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag ("Player")&&(this.gameObject.layer ==LAYER_BRONZE))
        {
            Destroy(this.gameObject);
            gameCoinsB.PlusCoinsBronze(1);
            Debug.Log(gameCoinsB.GetCoinsBronze());

          
        }
    }
}
