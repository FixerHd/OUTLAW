using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraindistance : MonoBehaviour
{
    public float distance;
    public Terrain terrain;
    void Start()
    {
        terrain.treeDistance = distance;
    }
}
