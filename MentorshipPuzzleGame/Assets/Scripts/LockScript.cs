using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public GameObject[] lockNumbers;
    public int currentLockNumber = 1;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //attempting to make the object in the array that shares the number in array as currentLockNumber set active
        for (int i = 0; i < 8; i++)
        {
            if (lockNumbers[i].GetComponent<float>() == currentLockNumber)
            {
                lockNumbers[i].SetActive(true);
            }
            else 
            {
                lockNumbers[i].SetActive(false);
            }
        }


        lockNumbers[currentLockNumber].SetActive(true);
        lockNumbers[currentLockNumber].SetActive(false);
    }

    public void IncreaseLockNumber()
    {
        if (currentLockNumber < 9)
        {
            currentLockNumber+= 1;
        }
        else if (currentLockNumber >= 9)
        {
            currentLockNumber = 0;
        }
    }

    public void DecreaseLockNumber()
    {
        if (currentLockNumber > 0)
        {
            currentLockNumber-= 1;
        }
        else if (currentLockNumber <= 0)
        {
            currentLockNumber = 9;
        }
    }
}
