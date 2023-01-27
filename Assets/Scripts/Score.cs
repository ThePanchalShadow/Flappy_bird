using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    #region Variables
    [Header("Vlaues")]
    public float speed = 1;
    [SerializeField] int score = 0;
    [SerializeField] int Checkscore;
    [SerializeField] int Coins = 0;
    [SerializeField] int TotalCoins=0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text coinsText;
    #endregion

    //To get Last Stored TotalCoins
    private void Start() => TotalCoins = PlayerPrefs.GetInt("TotalCoins");
    private void OnTriggerEnter2D(Collider2D other)
    {
        //If layer Goes through Between pipes Score will be incresed by 1 and 5 coins will be added
        if (other.CompareTag("Pipe"))
        {
            score++;
            scoreText.text = "Score:" + score.ToString();
            Coins = score * 5;
            coinsText.text = "Coins: " + Coins.ToString();
            
            //if Current Score is Greater then HighScore,HighScore will be Updated
            if (score > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
            IncreseSpeed();
        }
    }
    public void UpdateTotalCoins()
    {
        //When this Function is called the Collected coins by user in last game will be added to TotalCoins
        TotalCoins += Coins;
        PlayerPrefs.SetInt("TotalCoins", TotalCoins);
    }

    void IncreseSpeed()
    {
        //Increasing Speed every 2 Score
        Checkscore = 0;
        //float speed = _controlThePipes.speed;
        if (score % 2 == 0)
        {
            Checkscore = score - score / 2;
            if (Checkscore >= 2)
            {
                speed += 0.3f;
            }
            else if(score == 2)
            {
                speed = speed + 0.3f;
            }
        }
    }
}
