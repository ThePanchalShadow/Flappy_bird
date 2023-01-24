using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] float score = 0f;
    [SerializeField] Text scoreText= null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
