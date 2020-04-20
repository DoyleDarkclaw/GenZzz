using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;


public class spawner : MonoBehaviour
{

    public GameObject nepritel;
    public int pocetnepratel;
    public float spawnrate = 1f;

    private int i;
    private float nextTimeToFire = 0f;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (i >= pocetnepratel)
        {
            TurnOff();
        }
        
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / spawnrate;
            GameObject hodiny = Instantiate(nepritel);
            hodiny.transform.position = transform.position + (Vector3.up * Random.Range(1.0f, 2.0f)) + (Vector3.left * Random.Range(1.0f, 3.0f));
            
            i++;
        }


    }

    public void TurnOff()
    {
        this.enabled = false;
    }
}
