using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rizeni_hudby : MonoBehaviour
{
    public AudioClip prvni; //<---drag mp3 into the inspector here
    public AudioClip druhy;
    public AudioClip victory; //<---drag  mp3#2 into the inspector here
    AudioSource audio;

    int current;

    void Start()
    {
        // you need a reference to your component
        audio = gameObject.GetComponent<AudioSource>();
    }

    // now you should be able to say this anywhere else in your code
    void Update()
    {
        GameObject.Find("ALPHA GAME MANAGER").GetComponent<Rizeni_vln>().j = current;

        if (current == 1)
        {
            audio.clip = prvni;
            audio.Play();
           
         
        }

        if (current == 4)
        {
            audio.clip = druhy;
             audio.Play();


        }
        if (current == 6)
        {
            audio.clip = prvni;
             audio.Play();


        }

        if (current == 7)
        {
            audio.clip = victory;
            // audio.Play();


        }



    }
}