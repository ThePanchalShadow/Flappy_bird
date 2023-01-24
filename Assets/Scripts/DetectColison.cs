using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DetectColison : MonoBehaviour
{
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject Player;
    [SerializeField] private Animator anim;
    [SerializeField] private Jump Jump_script;
    private Vector3 playerpos;

    private void Start()
    {
        playerpos = Player.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gameover.SetActive(true);
            anim.SetTrigger("EndScore");
            Jump_script.enabled = false;
        }
    }

}
