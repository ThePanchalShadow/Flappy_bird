using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ControlThePipes : MonoBehaviour
{
    private float OutOfBound = -10;
    Score score;
    GameObject playerHolder; 
    
    void LateUpdate()
    {
        playerHolder = GameObject.FindGameObjectWithTag("Player");
        score = playerHolder.GetComponent<Score>();
        //it will continuosly moe the pipes with speed amount
        transform.Translate(Vector3.left * score.speed * Time.deltaTime);

        //if pipes go outside certain x vaule of their position they will be destroyed
        if (transform.position.x < OutOfBound)
        {
            //Destroys the Object this script is attached to
            Destroy(gameObject);
        }
    }

}
