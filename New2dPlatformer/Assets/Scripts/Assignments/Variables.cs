using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
   string firstname = "Derek";
   int age = 23;
   float height = 6.2f;
   bool married = false;


   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + firstname);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Marital Status: " + married);
    }
}
