using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucameramove : MonoBehaviour
{

    public float radius = 2.0f;        
    public float speed = 2.0f;         

    private Vector3 center;            
    private float angle = 0.0f;        
    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = center.y + Mathf.Cos(angle) * radius;
        float y = center.x;
        float z = center.z + Mathf.Sin(angle) * radius;

        
        transform.position = new Vector3(y, x, z);

        
        angle += speed * Time.deltaTime;

        if (angle >= 360.0f)
        {
            angle -= 360.0f;
        }
    }
}
