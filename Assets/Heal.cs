using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{

    public float health = 10f;
    
    //private float nextActionTime = 0.0f;
    //public float period = 0.1f;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    bool action = true;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            action = !action;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if ((collision.transform.tag == "Player")&&(action == true))
        {
            Target_Player target = collision.transform.GetComponent<Target_Player>();
                    if (target != null)
                    {
                      target.TakeHealth(health);
                      Debug.Log("Healed one");
                      action = false;
                      Destroy(gameObject);
                    }
            }
        }
}


//add this to Target_Player
/*public void TakeHealth(float amount)
    {
        health += amount;
    }*/


