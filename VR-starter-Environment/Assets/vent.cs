using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vent : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] private AudioSource openVentSound = null;
    [SerializeField] private float openDelay = 0.2f;
    
    [SerializeField] GameObject ventLockedMessage;


    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.eventShapesActive += OpenVent;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenVent()
    {
        animator.SetBool("Open", true);
        openVentSound.PlayDelayed(openDelay);
        ventLockedMessage.SetActive(false);
    }


}
