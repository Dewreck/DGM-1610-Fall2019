using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    
    //this defines the camera offset
    private Vector3 offset = new Vector3(25,0,5);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this tells the camera to follow the plane with offset
        transform.position = plane.transform.position + offset;
    }
}
