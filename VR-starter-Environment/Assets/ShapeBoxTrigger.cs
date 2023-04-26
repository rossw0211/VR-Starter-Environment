using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBoxTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Octogon")
        {
            GameEvents.current.SetShapesActive();
        }
    }

}
