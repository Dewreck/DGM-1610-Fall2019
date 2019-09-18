using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    
    //this defines the offeset of the camera
    private Vector3 offset = new Vector3(0,5,-7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this tells the camera to follow the car with offset
        transform.position = Player.transform.position + offset;
    }
}
