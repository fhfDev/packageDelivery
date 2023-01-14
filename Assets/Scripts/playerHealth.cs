using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    private int health = 100;
    public int maxHealth = 100;
    public healthDisplay healthBar;
    public int damage = 20;
   
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

        healthBar.SetHealth(amount);
        if (health <= 0)
        {
            playerCourier.enabled = false;
            playerwalk.enabled = false;
        }
        
    }
    void Update()
    {
        health = maxHealth - damage;
    } 

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(damage);
        }
    }
}
