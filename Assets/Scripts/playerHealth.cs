using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;

    public SpriteRenderer playerCourier;
    public playerWalk playerwalk;

    void Start()
    {
        health = maxHealth;    
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            playerCourier.enabled = false;
            playerwalk.enabled = false;
        }
        
    }
}
