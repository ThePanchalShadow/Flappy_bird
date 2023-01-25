using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ControlThePipes : MonoBehaviour
{
    public float speed = 3f;
    private float OutOfBound = -10;
    // Update is called once per frame

    private void Start()
    {
        speed = 3f;
    }
    void LateUpdate()
    {
        Debug.Log(speed);
        //it will continuosly moe the pipes with speed amount
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //if pipes go outside certain x vaule of their position they will be destroyed
        if (transform.position.x < OutOfBound)
        {
            //Destroys the Object this script is attached to
            Destroy(gameObject);
        }
    }

}
