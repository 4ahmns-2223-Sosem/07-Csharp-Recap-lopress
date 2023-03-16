using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WIP,
    Cancel
}

public class MyEnumsPract : MonoBehaviour
{
    //Deklaration
    State myState;


    // Start is called before the first frame update
    void Start()
    {
        myState = State.Done;

        switch (myState)
        {
            case State.Done:
                Debug.Log(State.Done + " " + (int)State.Done);
                break;
            case State.WIP:
                Debug.Log((int)State.WIP);
                break;
            case State.Cancel:
                Debug.Log((int)State.Cancel);
                break;
        }

        //gleiches wie SwitchCase nur als If dings
        if (myState == State.Done)
        {
            Debug.Log(State.Done + " " + (int)State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.Done + " " + (int)State.WIP);
        }
        else
        {
            Debug.Log(State.Done + " " + (int)State.Cancel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
