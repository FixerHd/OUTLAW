using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amadorsound : MonoBehaviour
{
    public GameObject amador;
    public GameObject player;
    public AudioSource chase;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(amador.transform.position, player.transform.position);
        if (distance < 20) chase.enabled = true;
        else chase.enabled = false;
    }
}
