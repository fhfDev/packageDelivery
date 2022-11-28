using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public playerHealth playerhealth;
    public int damage = 2;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    { 
        if(collision.gameObject.tag == "Player") 
        {
            playerhealth.TakeDamage(damage);
        }
    }
}
