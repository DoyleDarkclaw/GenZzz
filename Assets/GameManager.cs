using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    bool change = false;
    bool unchange = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //PLAYER UI INPUT AND SHIET
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            change = !change;
            unchange = !unchange;
            menu1.SetActive(change);
            menu2.SetActive(unchange);

            if(change==true) Time.timeScale = 0f;  
            else Time.timeScale = 1f;
        }
    }
}
