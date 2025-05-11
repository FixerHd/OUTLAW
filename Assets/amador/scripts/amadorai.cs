using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class amadorai : MonoBehaviour
{ 
    public GameObject amadordest;
    public GameObject amadordestalt;
    public GameObject amador;
    public GameObject player;
    NavMeshAgent amadoragent;
    public Animator animator;
    private float speed;
    private float distance;


    // Start is called before the first frame update
    void Start()
    {
        amadoragent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    { 
        

        if(player.transform.position.x<167.25 && player.transform.position.x > 150.11)
        {
            if(player.transform.position.z < 354.55 && player.transform.position.z > 344.48)
            {
                amadoragent.SetDestination(amadordestalt.transform.position);
            }
        }else amadoragent.SetDestination(amadordest.transform.position);

        distance = Vector3.Distance(amador.transform.position, player.transform.position);
        if (distance < 20) amadoragent.speed=10; 
        else amadoragent.speed = 6;
        speed = amadoragent.speed-1;
        animator.SetFloat("speed",speed);
    }
}
