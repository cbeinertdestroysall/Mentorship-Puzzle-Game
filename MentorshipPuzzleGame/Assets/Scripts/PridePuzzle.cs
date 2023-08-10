using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PridePuzzle : MonoBehaviour
{
    public GameObject[] blocks;

    public bool puzzleSolved = true;

    public GameObject door;

    public AudioSource youDidIt;

    public AudioSource error;

    public GameObject wrongCode;

    public GameObject rightCode;

    public GameObject itFeelsNice;

    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(1);
        wrongCode.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*for (int i = 0; i < blocks.Length; i++)
        {
            if (blocks[i].gameObject.GetComponent<LockScript>().currentLockNumber == blocks[i].gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = true;
            }
            else
            {
                puzzleSolved = true;
            }
        }*/

        /*foreach (GameObject block in blocks)
        {
            if (block.gameObject.GetComponent<LockScript>().currentLockNumber == block.gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = true;
            }
            else
            {
                puzzleSolved = false;
            }
        }*/

        for (int i = 0; i < blocks.Length; i++)
        {
            /*if (blocks[i].GetComponent<LockScript>().currentLockNumber == blocks[i].gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = true;
            }*/

            if (blocks[i].GetComponent<LockScript>().currentLockNumber != blocks[i].gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = false;
                break;
            }
            else if (blocks[i].GetComponent<LockScript>().currentLockNumber == blocks[i].gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = true;
            }
        }
        
    }

    public void ActivateDoor()
    {
        if (puzzleSolved)
        {
            door.SetActive(true);
            youDidIt.Play();
            rightCode.SetActive(true);
            itFeelsNice.SetActive(true);
        }
        else 
        {
            wrongCode.SetActive(true);
            StartCoroutine(DisableText());
            error.Play();
        }
    }


}
