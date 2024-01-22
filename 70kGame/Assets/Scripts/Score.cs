using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public int score, highScore;

    private void Update()
    {
        score = (int)(player.position.z / 2);
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("Score", highScore);
        }
        scoreText.text = ((int)(player.position.z / 2)).ToString();
    }
}
