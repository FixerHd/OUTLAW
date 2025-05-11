using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinkyappear : MonoBehaviour
{
    public GameObject tinky;
    public GameObject player;
    public float timer;
    public bool fart=false;
    public float timer2;
    // Start is called before the first frame update
    void Start()
    {
        timer = 20f;
        timer2 = 60f;
        tinky.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer2 -= Time.deltaTime;

        if (timer2 < 0)
        {
            tinky.SetActive(true);

            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 20f;
                timer2 = 60f;
                tinky.SetActive(false);
                fart = false;
            }
        }

        if (timer2 < 0 && !fart)
        {
            tinky.transform.position = new Vector3(player.transform.position.x - 5, player.transform.position.y, player.transform.position.z);
            fart = true;
        }
    }
}
