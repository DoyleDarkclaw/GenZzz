﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Posleni_pokus : MonoBehaviour
{
   
    public void Playgame()
    {

     UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    }

    public void MainMenu()
    {

     UnityEngine.SceneManagement.SceneManager.LoadScene(0);

    }


    public void Quitgame() 
    {
       
      
        Application.Quit(); 
    
    }

}
