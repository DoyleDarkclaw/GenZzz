using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class kolecka : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent playerAgent;
    private int i = 1;
    private UnityEngine.AI.NavMeshAgent agent;
    private Transform player;
    private Vector3 target;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       

    }

    // Update is called once per frame
    void Update()
    {

        if ((GameObject.Find("Kolo1") == null) && (GameObject.Find("Kolo2") == null))
        {
            

            agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
            this.GetComponent<Patrol>().enabled = false;
            this.GetComponent<enemyshoot>().enabled = false;
            this.GetComponent<enemyshoot2>().enabled = false;
            this.GetComponent<Attack>().enabled = true;
            GameObject.Find("BOSS").GetComponent<Target_mob>().health = 300;
            if (i == 1)
            { 
            agent.ResetPath();
                i++;
             }

            target = new Vector3(player.position.x, player.position.y, player.position.z);

            agent.SetDestination(player.position);

        }



    }
}
