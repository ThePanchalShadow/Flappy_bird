using TMPro;
using UnityEngine;


public class DetectColison : MonoBehaviour
{
    #region Variables    
    [Header("Objects")]
    [SerializeField] private Animator ScoreAnim;
    [SerializeField] private Animator PlayerAnim;
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject Player;
    [SerializeField] TMP_Text HighScore;
    [SerializeField] TMP_Text TotalCoins;
    
    [Space]
    [Header("Scripts")]
    [SerializeField] private Jump _jump;
    [SerializeField] private Score _score;

    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
            PlayerAnim.SetTrigger("Dead");
            gameover.SetActive(true);
            _jump.enabled = false;
            ScoreAnim.SetTrigger("EndScore");
            Player.GetComponent<Collider2D>().enabled = false;
            Invoke("timeStop", 2f);
            _score.UpdateTotalCoins();
            HighScore.text = "HighScore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
            TotalCoins.text = "TotalCoins : " + PlayerPrefs.GetInt("TotalCoins", 0).ToString();
        }
    }

    private void timeStop()
    {
        Time.timeScale = 0f;
    }


}
