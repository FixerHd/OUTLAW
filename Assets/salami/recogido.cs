using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recogido : MonoBehaviour
{
    public AudioSource audiorecolecta;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            audiorecolecta.Play();
            Destroy(this.gameObject);
        }
    }
}
