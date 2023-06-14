using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    public bool puzzleSolved = false;

    public GameObject[] slots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject slot in slots)
        {
            if (slot.GetComponent<WindowSlotScript>().pieceInCorrectSlot == true)
            {
                puzzleSolved = true;
            }
            else 
            {
                puzzleSolved = false;
            }
        }
    }
}
