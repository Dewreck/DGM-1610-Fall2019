using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    int num1;
    int num2;
    int total;
    public int firstnum = 0;
    public int secondnum = 0;
    // Start is called before the first frame update
    void Start()
    {
        // firstName = "Bob";

        // lastName = "Ross";

        // age = 90;

        // Customer(firstName, lastName, age);
        int num1 = 2;
        int num2 = 3;

        CalcAdd(11,23);

        CalcSub(55,5);

        CalcMult(num1, num2);

        CalcDiv(6,2);

        CalcMathAdd(firstnum, secondnum);
        
        CalcMathSub(firstnum, secondnum);
    }

    int CalcAdd (int n1, int n2)
    {
        Debug.Log("adding First Number: " + n1 + " and Second Number: " + n2);
        total = n1 + n2;

        Debug.Log(total);

        return total; 
    }
   
    int CalcSub (int num1, int num2)
    {
        Debug.Log("subtracting First Number: " + num1 + " and Second Number: " + num2);
        total = num1 - num2;
        Debug.Log(total);

        return total;
    }

    int CalcMult (int one, int two)
    {
        Debug.Log("multiplying First Number: " + one + " and Second Number: " + two);
        total = one * two;
        Debug.Log(total);
        return total;
    }

    int CalcDiv (int num1, int num2)
    {
        

        Debug.Log("dividing First Number: " + num1 + " by Second Number: " + num2);
        total = num1 / num2;
        Debug.Log(total);
        return total;
    }

    int CalcMathAdd (int lead, int follow)
    {
        Debug.Log("Adding your numbers: " + firstnum + "+" + secondnum);  
        total = firstnum + secondnum;
        Debug.Log(total);
        return total;
    } 

    int CalcMathSub (int lead, int follow)
    {
        Debug.Log("Subtracting your numbers: " + firstnum + "-" + secondnum);
        total= firstnum - secondnum;
        Debug.Log(total);
        return total;
    }


    // void Customer(string fName, string lName, int a)
    // {
    //     Debug.Log(fName + " " + lName + " " + a);
    // }
}
