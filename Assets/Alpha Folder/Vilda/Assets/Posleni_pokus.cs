using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Hosting;
using System.Diagnostics;

public class Posleni_pokus : MonoBehaviour
{
   
    public void Playgame()
    {

     UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    }
  
    public void Quitgame() 
    {
       
      
        Application.Quit(); 
    
    }

}
