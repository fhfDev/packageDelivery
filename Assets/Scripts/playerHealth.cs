using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

   public void Start()
    {
        
    }

    [System.Obsolete]
    public void Update()
    {
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;

        healthBar.fillAmount = healthAmount / 100f;
        
        
    }
}
