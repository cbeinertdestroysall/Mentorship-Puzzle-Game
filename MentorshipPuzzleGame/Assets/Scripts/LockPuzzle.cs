using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockPuzzle : MonoBehaviour
{
    public GameObject lockTop;
    public GameObject lockMiddle;
    public GameObject lockBottom;

    public GameObject key;

    public float correctLockNumberTop;
    public float correctLockNumberMiddle;
    public float correctLockNumberBottom;

    public AudioSource audioSource;

    public GameObject youDidItText;

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
        if (lockTop.GetComponent<LockScript>().currentLockNumber == correctLockNumberTop && lockMiddle.GetComponent<LockScript>().currentLockNumber == correctLockNumberMiddle && lockBottom.GetComponent<LockScript>().currentLockNumber == correctLockNumberBottom)
        {
            Debug.Log("you entered the correct code");
            key.GetComponent<ItemScript>().canBeUsed = true;
            audioSource.Play();
            youDidItText.SetActive(true);
        }
        else 
        {
            key.GetComponent<ItemScript>().canBeUsed = false;
            youDidItText.SetActive(false);
        }
    }

}
