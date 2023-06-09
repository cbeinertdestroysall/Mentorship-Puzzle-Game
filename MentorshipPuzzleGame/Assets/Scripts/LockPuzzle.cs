using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPuzzle : MonoBehaviour
{
    public GameObject lockTop;
    public GameObject lockMiddle;
    public GameObject lockBottom;

    public float correctLockNumber;

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
        }
    }

}
