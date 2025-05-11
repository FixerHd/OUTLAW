using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touched : MonoBehaviour
{

    public GameObject playercam;
    public GameObject player;
    public GameObject jumpcam;
    public AudioSource jumpsound;
    float cuenta = 0f;
    int segundos = 0;
    public bool tocao = false;

    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            player.SetActive(false);
            tocao = true;
            playercam.SetActive(false);
            jumpcam.SetActive(true);
            jumpsound.Play();
        }
    }

    private void Update()
    {
        if (tocao==true)
        {
            cuenta = cuenta + Time.deltaTime;
            if (cuenta >= 1)
            {
                cuenta = 0f;
                segundos++;
                
            }
        }
        if (segundos >= 2) SceneManager.LoadScene("GameOver");
    }
}
