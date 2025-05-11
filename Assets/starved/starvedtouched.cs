using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starvedtouched : MonoBehaviour
{

    public bool tocao = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            tocao = true;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tocao == true)
        {
            SceneManager.LoadScene("GameOverStarved");
        }
    }
}
