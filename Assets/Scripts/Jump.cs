using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float thrust = 3f;
    [SerializeField]bool isAndroid= false;
    bool gameStarted = false;

    private void Update()
    {
        
        if (gameStarted)
        {
            if(isAndroid)
            {
                if(Input.touchCount>0)
                {
                    jump();
                }
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.W))
                {
                    jump();
                }
            }
        }
        else if(Input.touchCount>0) gameStarted= true;
    }

    void jump()
    {
        animator.SetTrigger("Fly");
        player.velocity = new Vector2(0, thrust);
    }

}