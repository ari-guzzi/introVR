using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTarget : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 1.0f;//maximum distance it can move from the starting point

    private Vector3 startPosition;
    public bool moveInXDirection = true;
    void Start()
    {
        startPosition = transform.position; //save start position
    }

 void Update()
    {
        if (moveInXDirection)
        {
            transform.position = startPosition + new Vector3(Mathf.Sin(Time.time) * distance, 0f, 0f);
        }
        else
        {
            transform.position = startPosition + new Vector3(0f, 0f, Mathf.Sin(Time.time) * distance);
        }
    }


    private void OnCollisionEnter(Collision other){
        Destroy(this.gameObject); 
    }
}
