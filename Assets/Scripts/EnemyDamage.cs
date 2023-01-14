using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public playerHealth playerhealth;
    public int damage = 20;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision) 
    { 
        if(collision.gameObject.tag == "Player") 
        {
            playerhealth.TakeDamage(damage);
        }
    }
}
