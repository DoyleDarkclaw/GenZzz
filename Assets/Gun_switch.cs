using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_switch : MonoBehaviour
{
    public GameObject bullet;
    public GameObject ray;

    // Start is called before the first frame update
    void Start()
    {
        ray.SetActive(false);
        bullet.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ray.SetActive(false);
            bullet.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            ray.SetActive(true);
            bullet.SetActive(false);
        }
    }
}
