using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videos : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer vid1;

    void Awake()
    {
        vid1.Play();
        vid1.loopPointReached += Fart;
    }

    void Fart(VideoPlayer vid1)
    {
        SceneManager.LoadScene("GameOverStarved2");
    }

}
