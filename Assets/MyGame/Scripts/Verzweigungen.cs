using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verzweigungen : MonoBehaviour
{

    //Deklaration und Zuweisung einer Variable.
    int a = 4;

    //If-Statement.
    void Start()
    {
        if (a < 3)
        {
            Debug.Log("if is cool");
        }
        else
        {
            Debug.Log("else is cool");
        }
    }

}
