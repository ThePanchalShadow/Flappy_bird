using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    #region Variables
    public Animator PlayerAnim;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float thrust = 3f;
    [SerializeField]bool isAndroid= false;
    [SerializeField]bool gameStarted = false;
    #endregion

    private void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {

        if (Time.timeScale == 1)
        {
            if (isAndroid)
            {
                if (Input.touchCount > 0)
                {
                    jump();
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                jump();
            }
            
        }
        else if (Input.touchCount > 0 || Input.GetKey(KeyCode.W))
        {
            if (!gameStarted)
            {
                gameStarted = true;
                Time.timeScale = 1;
            }
        }
    }

    void jump()
    {
        PlayerAnim.SetTrigger("Fly");
        player.velocity = new Vector2(0, thrust);
    }

}