using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this makes objects that move out of the player's view destroy themselves
        if (transform.position.z > topBound) 
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            // triggers a Game Over! message
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
