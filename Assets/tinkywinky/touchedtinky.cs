using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchedtinky : MonoBehaviour
{

    
 
 
    public bool tocao = false;

    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            tocao = true;
           
        }
    }

    private void Update()
    {
        if (tocao == true)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
