using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action eventShapesActive;

    public event Action eventSafeActive;

    public void SetShapesActive()
    {

        Debug.Log("Event fucntion called");
        if(eventShapesActive != null)
        {
            eventShapesActive();
            Debug.Log("Shape Box Active Event");
        }
    }

    public void SetSafeActive()
    {

        Debug.Log("safe event called");
        if(eventSafeActive != null)
        {
            eventSafeActive();
            Debug.Log("safe active event");
        }
    }
}
