using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShots;
    [SerializeField]
    Transform shootPoint;
    public GameObject projectile;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }


    void Update()
    {
        if (timeBtwShots <= 0)
        {

            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        
        else {
            timeBtwShots -= Time.deltaTime * Random.Range(1.0f, 4.0f);
        }

    }


}

