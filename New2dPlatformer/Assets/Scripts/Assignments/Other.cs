using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    string firstName = "Kai";
    int level = 5;
    float height = 6.3f;
    bool slotsStatus = true;
    int numSlots = 6;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + firstName);
        Debug.Log("Current Level: " + level);
        Debug.Log("Height: " + height);
        Debug.Log("Spell Slots Available: " + slotsStatus);
        Debug.Log("# of Slots Available: " + numSlots);
    }

}
