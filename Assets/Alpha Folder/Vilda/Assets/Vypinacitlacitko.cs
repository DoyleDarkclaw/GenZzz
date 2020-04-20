using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Hosting;
using System.Diagnostics;

public class Vypinacitlacitko : MonoBehaviour
{

    public GameObject novakamara;
    public GameObject starakamera;
    public GameObject dialog;

    public void Start()
    {
        venzdialogu();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            dodialogu();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            venzdialogu();
        }
    }

    public void dodialogu()
    {
        dialog.SetActive(true);
        novakamara.SetActive(true);
        starakamera.SetActive(false);
    }

    public void venzdialogu()
    {
        dialog.SetActive(false);
        novakamara.SetActive(false);
        starakamera.SetActive(true);
    }



}