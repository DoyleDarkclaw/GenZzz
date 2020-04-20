using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
            Time.timeScale = 0f;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 1f;
        }
    }
}
