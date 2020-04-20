using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Druhypokus : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVOlume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);

    }
}
        
   

