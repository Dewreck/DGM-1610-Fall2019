using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcalc : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    int total;
    float divTotal;
    

    // Start is called before the first frame update
    void Start()
    {
        MathAdd (num1, num2);
        MathSub (num1, num2);
        MathMult (num1, num2);
        MathDiv (num1, num2);
    }

        int MathAdd(int first, int second)
        {
            total = first + second;
            Debug.Log("Sum: " + total);
            return total;
        }

        int MathSub(int first, int second)
        {
            total = first - second;
            Debug.Log("Difference: " + total);
            return total;
        }

        int MathMult(int first, int second)
        {
            total = first * second;
            Debug.Log("Product: " + total);
            return total;
        }

        float MathDiv(float first, float second)
        {
            divTotal = first / second;
            Debug.Log("Quotient: " + divTotal);
            return divTotal;
        }
}
