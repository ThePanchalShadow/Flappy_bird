using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    #region Variables
    [SerializeField] GameObject prefab;
    [SerializeField] float SpawnX;
    [SerializeField] float timeSpent;
    [SerializeField] float resetTime;

    [Space]
    [Header("Scripts")]
    [SerializeField] Score score;
    #endregion

    private void FixedUpdate()
    {
        Timer();
    }

    //This Fuction is a Timer which will Decide when to spawn Pipes
    void Timer()
    {
        //setting current time
        timeSpent += Time.deltaTime;

        //it conditon is true
        if(timeSpent >= resetTime )
        {
            //timespent will be reset to 0
            timeSpent = 0;
            //Amount of seconds that will decide when to spawn next Object
            resetTime = Random.Range(5f/score.speed, 7f/score.speed);
            //spawning the Pipes
            spawnPipes();
        }
    }
    void spawnPipes()
    {
        //setting Position Of spawn pipes ranomly but X position will stay same
        Vector2 spawnPos = new Vector2(SpawnX,Random.Range(-4.4f,-1.5f));
        //instantiating the pipe
        Instantiate(prefab,spawnPos,Quaternion.identity);
    }


}
