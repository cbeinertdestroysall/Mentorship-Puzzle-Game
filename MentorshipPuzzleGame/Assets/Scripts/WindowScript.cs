using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    public bool puzzleSolved = false;

    public GameObject[] slots;

    public AudioSource audioS;

    public GameObject window;

    public GameObject door;

    public GameObject wrongCode;

    public GameObject rightCode;

    public GameObject flashlight;

    //public AudioSource audioSource;

    IEnumerator WrongCode()
    {
        yield return new WaitForSeconds(1f);
        wrongCode.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puzzleSolved = true;
        foreach (GameObject slot in slots)
        {
            if (slot.GetComponent<WindowSlotScript>().pieceInCorrectSlot == true)
            {
                if (flashlight == null)
                {
                    puzzleSolved = puzzleSolved & true;
                }

                if (flashlight != null)
                { 
                    
                }
                
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
            window.SetActive(false);
            door.SetActive(true);
            wrongCode.SetActive(false);
            rightCode.SetActive(true);
        }
        else
        {
            wrongCode.SetActive(true);
            StartCoroutine(WrongCode());
        }
    }

    public void PlayPuzzleSolve()
    {
        if (puzzleSolved)
        audioS.Play();
    }
}
