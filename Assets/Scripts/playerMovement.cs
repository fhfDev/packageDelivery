using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float moveX = 0;
    float moveY = 0;
    float moveZ = 0;
    float speed = 3; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        moveZ = Input.GetAxis("Jump") * Time.deltaTime * speed;
        transform.Translate(moveX,moveY,moveZ);
    }
}
