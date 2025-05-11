using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class nemonacontrol : MonoBehaviour
{

    public float timer = 600;
    public float timer2 = 100;
    public bool fart = false;
    public GameObject nemona;
    public AudioSource sound2;
    // Start is called before the first frame update
    void Start()
    {
        nemona.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timer2 -= Time.deltaTime;

        if (timer2 <= 0 && !fart)
        {
            timer2 = 100;
            sound2.Play();
        }

        if (timer <= 0)
        {

            nemona.SetActive(true);
                fart = true;
            
        }
    }
}
