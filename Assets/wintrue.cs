using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wintrue : MonoBehaviour
{
    public int salamis = 0;
    public bool salami1des = true;
    public bool salami2des = true;
    public bool salami3des = true;
    public bool salami4des = true;
    public bool salami5des = true;
    public bool salami6des = true;
    public bool salami7des = true;
    public bool salami8des = true;

    public Text textoSalami;

    public GameObject salami1;

    public GameObject salami2;

    public GameObject salami3;

    public GameObject salami4;

    public GameObject salami5;

    public GameObject salami6;

    public GameObject salami7;

    public GameObject salami8;

    // Update is called once per frame
    void Update()
    {
        if (salami1.IsDestroyed() && salami1des)
        {
            salami1des = false;
            salamis++;
        }

        if (salami2.IsDestroyed() && salami2des)
        {
            salami2des = false;
            salamis++;
        }

        if (salami3.IsDestroyed() && salami3des)
        {
            salami3des = false;
            salamis++;
        }

        if (salami4.IsDestroyed() && salami4des)
        {
            salami4des = false;
            salamis++;
        }

        if (salami5.IsDestroyed() && salami5des)
        {
            salami5des = false;
            salamis++;
        }

        if (salami6.IsDestroyed() && salami6des)
        {
            salami6des = false;
            salamis++;
        }

        if (salami7.IsDestroyed() && salami7des)
        {
            salami7des = false;
            salamis++;
        }

        if (salami8.IsDestroyed() && salami8des)
        {
            salami8des = false;
            salamis++;
        }
        if (salami1.IsDestroyed() && salami2.IsDestroyed() && salami3.IsDestroyed() && salami4.IsDestroyed() && salami5.IsDestroyed() && salami6.IsDestroyed() && salami7.IsDestroyed() && salami8.IsDestroyed()) SceneManager.LoadScene("falsewin");

        textoSalami.text = salamis.ToString() + "/8 Salamis";
    }
}
