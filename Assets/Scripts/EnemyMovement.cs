using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public new Rigidbody2D rigidbody;
    public bool random;
    float originalY;

    public float floatStrength = 1;

    void Start()
    {
        this.originalY = this.transform.position.y;

        if (random)
        {
            rigidbody.velocity = Random.value * transform.right * speed;
        }
        else
        {
            rigidbody.velocity = transform.forward * speed;
        }


    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x,
               originalY + ((float)System.Math.Sin(Time.time) * floatStrength),
               transform.position.z);
    }
}

