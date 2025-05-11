using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posemodelvr : MonoBehaviour
{
    public GameObject camera;
    public float difposy;
    public float difposz;
    public float difposx;
    // Start is called before the first frame update
    void Start()
    {
        difposy = this.transform.position.y - camera.transform.position.y;
        difposz = this.transform.position.z - camera.transform.position.z;
        difposx = this.transform.position.x - camera.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(camera.transform.position.x + difposx, camera.transform.position.y + difposy, camera.transform.position.z + difposz);
        this.transform.rotation = new Quaternion(this.transform.rotation.x, camera.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
    }
}
