using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; 
    public float speed = 15f;
    public float xRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this gets the player input
        horizontalInput = Input.GetAxis("Horizontal");
        
        // this moves the player based on input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // this bounds the player on the left
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // this bounds the player on the right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}
