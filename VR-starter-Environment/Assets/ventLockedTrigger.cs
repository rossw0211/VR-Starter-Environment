using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventLockedTrigger : MonoBehaviour
{
    [SerializeField] GameObject showLockedMessage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            showLockedMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            showLockedMessage.SetActive(false);
        }
    }
}
