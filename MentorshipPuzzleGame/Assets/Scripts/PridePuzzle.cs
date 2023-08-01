using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PridePuzzle : MonoBehaviour
{
    public GameObject[] blocks;

    public bool puzzleSolved = false;

    public GameObject door;

    public AudioSource youDidIt;

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

        foreach (GameObject block in blocks)
        {
            if (block.gameObject.GetComponent<LockScript>().currentLockNumber == block.gameObject.GetComponent<LockScript>().correctLockNumber)
            {
                puzzleSolved = true;
            }
            else
            {
                puzzleSolved = false;
            }
        }
    }

    public void ActivateDoor()
    {
        if (puzzleSolved)
        {
            door.SetActive(true);
            youDidIt.Play();
        }
    }


}
