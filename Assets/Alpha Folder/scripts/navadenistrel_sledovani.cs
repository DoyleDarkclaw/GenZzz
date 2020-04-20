using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class navadenistrel_sledovani : MonoBehaviour
{
    public float speed;
    private Transform player;
        private Vector3 target;

    
    public float lifeDuration = 2f;

    private float lifeTimer;

    // Start is called before the first frame update
    void Start()
    {

        lifeTimer = lifeDuration;
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
