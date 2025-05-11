using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject dia;
    public GameObject tarde;
    public GameObject noche;
    public GameObject play;
    public GameObject exit;
    public GameObject back;
    public GameObject image;
    public GameObject cam;
    public GameObject cam2;

    public GameObject low;
    public GameObject medium;
    public GameObject high;

    public GameObject options;

    public GameObject yo;
    public GameObject yo2;
    public GameObject yo3;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)) {
            SceneManager.LoadScene("Void");
        }
    }

    public void Escenajuego()
    {
        yo2.SetActive(false);
        yo3.SetActive(false);
        yo.SetActive(false);
        image.SetActive(false);
        cam.SetActive(true);
        dia.SetActive(true);
        tarde.SetActive(true);
        noche.SetActive(true);
        play.SetActive(false);
        exit.SetActive(false);
        back.SetActive(true);
        options.SetActive(false);

    }

    public void Options()
    {
        yo2.SetActive(false);
        yo3.SetActive(false);
        play.SetActive(false);
        exit.SetActive(false);
        yo.SetActive(false);
        image.SetActive(false);
        cam2.SetActive(true);
        back.SetActive(true);
        options.SetActive(false);
        low.SetActive(true);
        medium.SetActive(true);
        high.SetActive(true);
    }

    public void Noche()
    {
        SceneManager.LoadScene("Noche");
    }

    public void Tarde()
    {
        SceneManager.LoadScene("Tarde");
    }

    public void Dia()
    {
        SceneManager.LoadScene("Dia");
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        yo2.SetActive(true);
        yo3.SetActive(true);
        yo.SetActive(true);
        cam.SetActive(false);
        image.SetActive(true);
        dia.SetActive(false);
        tarde.SetActive(false);
        noche.SetActive(false);
        play.SetActive(true);
        exit.SetActive(true);
        back.SetActive(false);
        options.SetActive(true);
        cam2.SetActive(false);
        low.SetActive(false);
        medium.SetActive(false);
        high.SetActive(false);
    }
}
