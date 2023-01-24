using UnityEngine;


public class DetectColison : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject Player;
    [SerializeField] private Animator ScoreAnim;
    [SerializeField] private Animator PlayerAnim;
    //[SerializeField] private GameObject Base;
    //[SerializeField] private Collider2D playerC;
    //[SerializeField] private Rigidbody2D playerRB;
    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            PlayerAnim.SetTrigger("Dead");
            gameover.SetActive(true);
            ScoreAnim.SetTrigger("EndScore");
            Player.GetComponent<Collider2D>().enabled = false;
            Player.GetComponent<Rigidbody2D>().gravityScale = 0;
            Invoke("timeStop", 2f);
        }
    }

    private void timeStop()
    {
        Time.timeScale = 0f;
    }

}
