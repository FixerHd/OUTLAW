using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepssound : MonoBehaviour
{
    
    public AudioSource pasosandando;
    public AudioSource pasoscorriendo;

    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
            pasoscorriendo.enabled = true;
            pasosandando.enabled = false;
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            pasosandando.enabled = true;
            pasoscorriendo.enabled = false;
        }
        else
        {
            pasosandando.enabled = false;
            pasoscorriendo.enabled = false;
        }

    }
}
