using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class gasterdai : MonoBehaviour
{

    public GameObject amadordest;
    public GameObject amadordestalt;
    public GameObject run;
    public GameObject walk;
    public GameObject amador;
    public GameObject player;
    NavMeshAgent amadoragent;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        amadoragent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {


        if (player.transform.position.x < 167.25 && player.transform.position.x > 150.11)
        {
            if (player.transform.position.z < 354.55 && player.transform.position.z > 344.48)
            {
                amadoragent.SetDestination(amadordestalt.transform.position);
            }
        }
        else amadoragent.SetDestination(amadordest.transform.position);

        distance = Vector3.Distance(amador.transform.position, player.transform.position);
        if (distance < 20)
        {
            run.SetActive(true);
            walk.SetActive(false);
            amadoragent.speed = 6.5f;
        }
        else
        {
            run.SetActive(false);
            walk.SetActive(true);
            amadoragent.speed = 4;
        }
 
    }
}
