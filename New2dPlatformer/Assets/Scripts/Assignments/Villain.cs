using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    string badGuy = "He Who Smelt It";
    bool contain = false;
    int age = 43;
    float height = 5.9f;
    string reason = "Wanted for multiple counts of undocumented 'cropdusting'";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + badGuy);
        Debug.Log("Detainment Status: " + contain);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log(reason);
          
    }


}
