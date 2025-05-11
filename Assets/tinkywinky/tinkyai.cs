using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class tinkyai : MonoBehaviour
{
    public GameObject tinkydest;
    public GameObject tinkydestalt;
    public GameObject tinky;
    public GameObject player;
    public GameObject image;
    public bool fart;
    NavMeshAgent tinkyagent;
    private float distance;
    public AudioSource jumpsound;


    // Start is called before the first frame update
    void Start()
    {
        tinkyagent = GetComponent<NavMeshAgent>();
        fart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < 167.25 && player.transform.position.x > 150.11)
        {
            if (player.transform.position.z < 354.55 && player.transform.position.z > 344.48)
            {
                tinkyagent.SetDestination(tinkydestalt.transform.position);
            }
        }
        else tinkyagent.SetDestination(tinkydest.transform.position);

        
        

         distance = Vector3.Distance(tinky.transform.position, player.transform.position);
        if (distance < 100)
        {
            jumpsound.enabled = true;
            if (!fart)
            {
                image.SetActive(true);
            }
            fart = true;
        }

        else
        {
            jumpsound.enabled = false;
            image.SetActive(false);
            fart = false;
        }
            tinkyagent.speed = 7;
    }
}
