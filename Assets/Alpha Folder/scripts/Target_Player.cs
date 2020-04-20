using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Player : MonoBehaviour
{
    public Slider healthbar;
    public float health = 100;

    public void TakeDamage (float amount)
    {
        health -= amount;
        
        if(health <= 0f)
        {
            Die();
        }
    }

    public void TakeHealth(float amount)
    {
        health += amount;
        if (health <= 100) { health = 100; }
    }
    
    void Update()
    {
        healthbar.value = health;
        ChangeHealth();
    }

    void Die()
    { // tady ještě musíme dodělat smrt hráče
        Destroy(gameObject);
    }
    void ChangeHealth()
    {
        if (Input.GetKeyDown(KeyCode.Z)) { health = health - 20; }
    }
  
}
