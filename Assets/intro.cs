using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class intro : MonoBehaviour
{
    public VideoPlayer vid1;

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
