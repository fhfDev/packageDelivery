using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{
    public Slider slider;
    readonly playerHealth player;
    public Image redbar;
    public int damage = 20;

    void Awake()
    {
        slider= GetComponent<Slider>();
    }
    void Update()
    {
        player.TakeDamage(damage);
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue= health;
        slider.value= health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }

    
}

