using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_mob : MonoBehaviour
{

    public float health = 50f;
    public float damage = 25f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    public void OnCollisionEnter(Collision _collision)
    {

        if (_collision.gameObject.tag == "kulka")
        {
            TakeDamage(damage);
        }

        void TakeDamage(float amount)
        {
            health -= amount;

            if (health <= 0f)
            {
                Die();
            }
        }       
    }

    public void Die()
        { // tady ještě musíme dodělat smrt hráče
            Destroy(gameObject);
        }
}
