using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;
    public healthDisplay healthBar;

    public SpriteRenderer playerCourier;
    public playerWalk playerwalk;

   public void Start()
    {
        health = maxHealth;    
        healthBar.SetMaxHealth(maxHealth);
    }
    

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.SetMaxHealth(health);
        if (health <= 0)
        {
            playerCourier.enabled = false;
            playerwalk.enabled = false;
        }
        
    }
    
}
