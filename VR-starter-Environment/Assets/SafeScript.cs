using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeScript : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] private AudioSource openSafeSound = null;
    [SerializeField] private float openDelay = 0.2f;

    [SerializeField] private AudioSource winSound = null;
    [SerializeField] private float winSoundDelay = 0.3f;

    [SerializeField] GameObject showWinMessage;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.eventSafeActive += OpenSafe;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenSafe()
    {
        animator.SetBool("Open", true);

        openSafeSound.PlayDelayed(openDelay);

        winSound.PlayDelayed(winSoundDelay);

        showWinMessage.SetActive(true);

    }
}
