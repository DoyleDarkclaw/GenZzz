using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public float damage = 10f;
    public float forceApplied = 10f;
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
                      target.TakeDamage(damage);
                      target.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
                      Debug.Log("Hit one");
                      action = false;
                    }
            }
        }
    }


