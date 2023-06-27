using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource switchSound;
    public AudioSource grabSound;
    public AudioSource lockSwitch;
    public AudioSource draggingSound;
    public AudioSource charge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySwitch()
    {
        switchSound.Play();  
    }

    public void PlayGrab()
    {
        grabSound.Play();
    }

    public void PlayLockSwitch()
    {
        lockSwitch.Play();
    }

    public void PlayDraggingSound()
    {
        draggingSound.Play();
    }

    public void StopDraggingSound()
    {
        draggingSound.Stop();
    }

    public void PlayCharge()
    {
        charge.Play();
    }
    
}
