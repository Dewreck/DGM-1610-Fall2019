using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartoon : MonoBehaviour
{
    string fullname = "Rick Sanchez";
    int age = 70;
    float height = 6.5f;
    bool pickle = true;
    string occupation = "Scientist";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + fullname);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Occupation: " + occupation);
        Debug.Log("Currently a Pickle: " + pickle);
    }

  
}
