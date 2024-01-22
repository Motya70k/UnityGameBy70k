using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowCoins : MonoBehaviour
{
    public int coins, score;
    public TextMeshProUGUI coinsText, scoreText;
    void Awake()
    {
        coins = PlayerPrefs.GetInt("Coin");
        coinsText.text = coins.ToString();
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString();
    }
}
