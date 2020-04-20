using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class navadenistrel : MonoBehaviour
{
    public float speed;
    private Transform player;
        private Vector3 target;

    private Transform playerTransform;
    private Transform selfTransform;
    private Vector3 playerPosition;
    private Vector3 direction;





    public float lifeDuration = 2f;

    private float lifeTimer;

    // Start is called before the first frame update
    void Start()
    {

        lifeTimer = lifeDuration;
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        
        playerPosition = playerTransform.position;
        selfTransform = GetComponent<Transform>();
        direction = (playerPosition - selfTransform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {

        selfTransform.position += direction * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
