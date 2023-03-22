using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //Deklaration eines Arrays
    int[] zahlenReihe = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

    void Start()
    {
        //Ausgeben von dem zweiten Element (also eigentlich das dritte, weil ja mit Null begonnen wird!)
        Debug.Log(zahlenReihe[2]);

        //Ändern von dem sechsten Element (die Zahl 5) in die Zahl 13 und anschließend Ausgeben in der Console.
        zahlenReihe[6] = 13;
        Debug.Log(zahlenReihe[6]);
    }
}
