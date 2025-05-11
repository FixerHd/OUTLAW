using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphicpresets : MonoBehaviour
{
    public void Low()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void Medium()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void High()
    {
        QualitySettings.SetQualityLevel(2);
    }

}
