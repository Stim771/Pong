using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTest : MonoBehaviour
{
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
         Sum(a, b);
         Product(a, b);
         Div(a, b);
    }
    float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return (a + b);
    }
    float Product(float a, float b)
    {
        Debug.Log(a * b);
        return (a * b);
    }
    float Div(float a, float b)
    {
    if (b == 0)
        {
            Debug.Log("False");
            return -1;
        }
        else
        {
            Debug.Log("True");
        }
        Debug.Log(a / b);
        return (a / b);
    }
}
