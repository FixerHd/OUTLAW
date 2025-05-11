using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image : MonoBehaviour
{
    public float radius = 2.0f;
    public float speed = 2.0f;
    public float timer;

    private Vector3 center;
    private float angle = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
        timer = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = center.x + Mathf.Cos(angle) * radius;
        float y = center.y + Mathf.Sin(angle) * radius;
        float z = center.z + Mathf.Sin(angle) * radius;


        transform.position = new Vector3(x, y, z);


        angle += speed * Time.deltaTime;

        if (angle >= 360.0f)
        {
            angle -= 360.0f;
        }

        timer -= Time.deltaTime;

        if(timer < 0)
        {
            timer = 1.5f;
            gameObject.SetActive(false);
        }
    }


}
