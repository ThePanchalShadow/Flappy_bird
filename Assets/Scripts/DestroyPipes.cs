using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPipes : MonoBehaviour
{
    GameObject[] obstacls;
    public void DestroyAll()
    {
        obstacls = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach(GameObject i in obstacls)
        {
            i.SetActive(false);
        }

        Invoke("Restart", 0);
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
