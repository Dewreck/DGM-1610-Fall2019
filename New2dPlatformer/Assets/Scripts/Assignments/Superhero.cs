using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero : MonoBehaviour
{
    string hero = "Fulminator";
    int rank = 6;
    string group = "S Class";
    float power = 9000.1f;
    bool active = true;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hero Name: " + hero);
        Debug.Log("Hero Ranking: " + rank + ", " + group);
        Debug.Log("Power Level: " + power);
        Debug.Log("Active Duty Status: " + active);
    }

    
}
