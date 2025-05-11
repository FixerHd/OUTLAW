using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nemonai : MonoBehaviour
{
    public GameObject nemona;
    public NavMeshAgent nemonaagent;
    public GameObject player;
    public AudioSource sound;

    private void Start()
    {
        nemonaagent.SetDestination(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
            nemonaagent.SetDestination(player.transform.position);
            nemonaagent.speed = 10;
        }
    }

