using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{

    public Animator animator;
    public GameObject camara;
    public float blend;

    // Start is called before the first frame update
    void Start()
    {
        blend = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            blend = 0.5f;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                blend = 1;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            blend = 0.5f;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                blend = 1;
            }


        }
        else
        {
            blend = 0;
        }
            animator.SetFloat("Blend", blend);
    }
}
