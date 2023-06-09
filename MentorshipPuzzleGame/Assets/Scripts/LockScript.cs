using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public GameObject[] lockNumbers;
    public int currentLockNumber = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lockNumbers.Length; i++)
        {
            if (i == currentLockNumber)
            {
                lockNumbers[i].SetActive(true);
            }
            else
            {
                lockNumbers[i].SetActive(false);
            }
        }
    }

    public void IncreaseLockNumber()
    {
        if (currentLockNumber < 8)
        {
            currentLockNumber+= 1;
        }
        else if (currentLockNumber >= 8)
        {
            currentLockNumber = 0;
        }

        for (int i = 0; i < lockNumbers.Length; i++)
        {
            if (i == currentLockNumber)
            {
                lockNumbers[i].SetActive(true);
            }
            else
            {
                lockNumbers[i].SetActive(false);
            }
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
            currentLockNumber = 8;
        }

        for (int i = 0; i < lockNumbers.Length; i++)
        {
            if (i == currentLockNumber)
            {
                lockNumbers[i].SetActive(true);
            }
            else
            {
                lockNumbers[i].SetActive(false);
            }
        }
    }
}
