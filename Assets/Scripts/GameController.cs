using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreText;
    public Text CoinGoldText;
    public Text CoinSilverText;
    public Text CoinBronzeText;

    private int score = 0;
    private int cGold = 0;
    private int cSilver = 0;
    private int cBronze = 0;

    void Start()
    {
        //muestra el puntaje inicial
        ScoreText.text = "Score: " + score;
        CoinGoldText.text = "Coins Gold: " + cGold;
        CoinSilverText.text = "Coins Silver: " + cSilver;
        CoinBronzeText.text = "Coins Bronze: " + cBronze;

    }
    public int GetScore()
    {
        return this.score;
    }
    public int GetCoinsGold()
    {
        return this.cGold;
    }
    public int GetCoinsSilver()
    {
        return this.cSilver;
    }
    public int GetCoinsBronze()
    {
        return this.cBronze;
    }
    public void PlusScore(int score)
    {
        this.score += score;
        ScoreText.text = "Score: " + score;
    }
    public void PlusCoinsGold(int cGold)
    {
        this.cGold += cGold;
        CoinGoldText.text = "Coins Gold: " + cGold;
    }
    public void PlusCoinsSilver(int cSilver)
    {
        this.cSilver += cSilver;
        CoinSilverText.text = "Coins Silver: " + cSilver;
    }
    public void PlusCoinsBronze(int cBronze)
    {
        this.cBronze += cBronze;
        CoinBronzeText.text = "Coins Bronze: " + cBronze;
    }
}
