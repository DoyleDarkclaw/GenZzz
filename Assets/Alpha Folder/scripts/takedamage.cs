using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takedamage : MonoBehaviour
{

    public float Health = 50;
    int damage = 10;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCOllisionEnter(Collision _collision)
    {

        if (_collision.gameObject.tag == "kulka")
        {

            Health -= damage;
            print("Ripik pipik" + Health);
        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
