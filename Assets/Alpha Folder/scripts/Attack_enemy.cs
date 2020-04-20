using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_enemy : MonoBehaviour
{

    public float damage = 10f;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "Player")
        {
            Target_Player target = collision.transform.GetComponent<Target_Player>();
            


            if (target != null)
                    {
                      target.TakeDamage(damage);
                      Debug.Log(damage);
                Destroy(gameObject);
            }
           

        }
        Destroy(gameObject);
    }
   
   






}

    


