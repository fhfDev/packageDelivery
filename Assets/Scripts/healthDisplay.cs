using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;

    public Image[] hearts;

    public playerHealth playerhealth;
    void Start()
    {

    }

    void Update()
    {
        health = playerhealth.health;
        maxHealth= playerhealth.maxHealth;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}

