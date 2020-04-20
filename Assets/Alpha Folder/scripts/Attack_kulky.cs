using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_kulky : MonoBehaviour
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

    public void OnCollisionEnter(Collision _collision)
    {
       
            Target target = _collision.transform.GetComponent<Target>();



            if (target != null)
            {
                target.TakeDamage(damage);
                Debug.Log(damage);
                Destroy(gameObject);
            }
        

    }





}

    


