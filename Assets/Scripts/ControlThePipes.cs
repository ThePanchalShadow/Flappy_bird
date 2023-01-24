using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ControlThePipes : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    private float OutOfBound = -10;
    // Update is called once per frame
    void LateUpdate()
    {
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
