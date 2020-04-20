using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rizeni_vln : MonoBehaviour
{

    public GameObject Spawner1;
    public GameObject Spawner2;
public GameObject Spawner3;
public GameObject Spawner4;
public GameObject Spawner5;
public GameObject Spawner6;
public GameObject Spawner7;
public GameObject Spawner8;
public GameObject Spawner9;
public GameObject Spawner10;
public GameObject Spawner11;
public GameObject Spawner12;
public GameObject Spawner13;
public GameObject Spawner14;
public GameObject Spawner15;
public GameObject Spawner16;
public GameObject Spawner17;
public GameObject Spawner18;


public GameObject mob1;
public GameObject mob2;
public GameObject mob3;
public GameObject mob4;
public GameObject mob5;
public GameObject mob6;
public GameObject mob7;
public GameObject mob8;
public GameObject mob9;
public GameObject mob10;
public GameObject mob11;
public GameObject mob12;
public GameObject mob13;
public GameObject mob14;
public GameObject mob15;
public GameObject mob16;
public GameObject mob17;
public GameObject mob18;
public GameObject mob19_matka;
public GameObject mob20;
public GameObject mob21;
public GameObject mob22;
public GameObject mob23;
public GameObject mob24;
public GameObject mob25;
public GameObject mob26_boss;
    

    public int j;
    private int k = 0;
   

    void Update()
    {

        // V Game objectu, co ma skript na rozhovor udelame public int i = 0, poslední klik rozhovoru zvysi na 1.

        GameObject.Find("Dialog Manager").GetComponent<Vypinacitlacitko>().i = j; 



        if ((j == 1) && (k == 0)) 
    {
            // spusti se vlna 1, jeste je potreba zmenit hudbu
            k = k + 1;
        Spawner1.SetActive(true);
            
        Spawner2.SetActive(true);
        Spawner3.SetActive(true);
            
            Spawner4.SetActive(true);
        Spawner5.SetActive(true);
        mob1.SetActive(true);
        mob2.SetActive(true);
        mob3.SetActive(true);
            
            mob4.SetActive(true);
        mob5.SetActive(true);
        mob6.SetActive(true);
            
            mob7.SetActive(true);
        mob8.SetActive(true);
        mob9.SetActive(true);
            k = k + 1;

            // k = 2, j = 1
    }
       
        
        // rozhovor 2
        if ((GameObject.Find("Spawner1") == null) && (GameObject.Find("Spawner2") == null) && ((k == 2) && (j == 1))) 
        {
            // vlna 2, dodelat hudbu

            Spawner6.SetActive(true);
            Spawner7.SetActive(true);
     
            Spawner8.SetActive(true);
            Spawner9.SetActive(true);
            Spawner10.SetActive(true);
            mob10.SetActive(true);
            mob11.SetActive(true);
            
            mob12.SetActive(true);
            mob13.SetActive(true);
            mob14.SetActive(true);
          
            mob15.SetActive(true);
            mob16.SetActive(true);
            mob17.SetActive(true);
            mob18.SetActive(true);
           
            
            k = k + 1;
            // k = 3, j = 2

        }

        if ((GameObject.Find("Spawner6") == null) && (GameObject.Find("Spawner7") == null) && ((k == 3) && (j == 1)))
        {
            //spawn matky
            mob19_matka.SetActive(true);
            k = k + 1;
            // k=4 j=2
        }
        
        
        
        //rozhovor3

        if ((GameObject.Find("mob_19matka") == null) && ((k == 4) && (j == 1)))
        {
            //posledni vlna 3 dodelat hudbu, spawne se vozík, po zabití vozíku end game
            Spawner11.SetActive(true);
            Spawner12.SetActive(true);
            Spawner13.SetActive(true);
            Spawner14.SetActive(true);

            Spawner15.SetActive(true);
            Spawner16.SetActive(true);
            Spawner17.SetActive(true);
            Spawner18.SetActive(true);
            mob20.SetActive(true);
            mob21.SetActive(true);

            mob22.SetActive(true);
            mob23.SetActive(true);
            mob24.SetActive(true);

            mob25.SetActive(true);
            
            k = k + 1;

        }

        if ((GameObject.Find("Spawner11") == null) && (GameObject.Find("Spawner12") == null) && ((k == 5) && (j == 1)))
        {
            mob26_boss.SetActive(true);
            k = k + 1;
        }

        // Rozhovor po bossovi

        if ((GameObject.Find("mob_mob26_boss") == null) && ((k == 6) && (j == 1)))
        {
            k = k + 1;
           // Rozbraz ENDGAMEscreen, mozna nejaka hudba?
        }
    }

   
    
    
    
    
    
    
  



}