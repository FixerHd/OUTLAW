using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class win : MonoBehaviour
{


    public VideoPlayer vid1;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Start is called before the first frame update

    void Awake()
    {
        vid1.Play();
        vid1.loopPointReached += Fart;
    }

    void Fart(VideoPlayer vid1)
    {
        SceneManager.LoadScene("Menu");
    }

}
