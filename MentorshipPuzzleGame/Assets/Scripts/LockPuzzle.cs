using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPuzzle : MonoBehaviour
{
    public GameObject lockTop;
    public GameObject lockMiddle;
    public GameObject lockBottom;

    public GameObject key;

    public float correctLockNumber;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SolvePuzzle()
    {
        if (lockTop.GetComponent<LockScript>().currentLockNumber == correctLockNumber && lockMiddle.GetComponent<LockScript>().currentLockNumber == correctLockNumber && lockBottom.GetComponent<LockScript>().currentLockNumber == correctLockNumber)
        {
            Debug.Log("you entered the correct code");
            key.GetComponent<ItemScript>().canBeUsed = true;
            audioSource.Play();
        }
        else 
        {
            key.GetComponent<ItemScript>().canBeUsed = false;
        }
    }

}
