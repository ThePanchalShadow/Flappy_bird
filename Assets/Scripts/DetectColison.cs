using TMPro;
using UnityEngine;


public class DetectColison : MonoBehaviour
{
    #region Variables   

    [Header("Animator")]
    [SerializeField] private Animator ScoreAnim;
    [SerializeField] private Animator PlayerAnim;

    [Space]
    [Header("Objects")]
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject Player;

    [Space]
    [Header("TMP_Text")]
    [SerializeField] TMP_Text HighScore;
    [SerializeField] TMP_Text TotalCoins;
    
    [Space]
    [Header("Scripts")]
    [SerializeField] private Jump _jump;
    [SerializeField] private Score _score;

    [Space]
    [Header("Audio")]
    [SerializeField] AudioSource Loose;
    

    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //Death Sound
            Loose.Play();

            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
            PlayerAnim.SetTrigger("Dead");
            gameover.SetActive(true);
            _jump.enabled = false;
            
            ScoreAnim.SetTrigger("EndScore");
            Player.GetComponent<Collider2D>().enabled = false;

            _score.UpdateTotalCoins();
            HighScore.text = "HighScore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
            TotalCoins.text = "TotalCoins : " + PlayerPrefs.GetInt("TotalCoins", 0).ToString();
            
            Invoke("timeStop", 2f);
        }
    }

    private void timeStop()
    {
        Time.timeScale = 0f;
    }


}
