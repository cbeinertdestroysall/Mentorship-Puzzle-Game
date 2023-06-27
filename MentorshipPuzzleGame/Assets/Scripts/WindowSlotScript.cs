using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSlotScript : MonoBehaviour
{
    public float slotNumber;

    public bool pieceInCorrectSlot = false;

    public bool pieceInSlot = false;

    public bool correctRotation = false;

    public int rotationMin;
    public int rotationMax;

    public WindowScript windowScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            pieceInSlot = true;
            if (collision.GetComponent<PuzzlePieceScript>().puzzleNumber == slotNumber)
            {
                pieceInCorrectSlot = true;

                

                /*if (windowScript.puzzleSolved)
                {
                    Debug.Log("You solved the window puzzle");
                }*/
            }
            else 
            {
                pieceInCorrectSlot = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            pieceInSlot = true;

            if (this.GetComponent<RotateObject>() != null)
            {
                if (collision.transform.rotation.z >= rotationMin && collision.transform.rotation.z <= rotationMax)
                {
                    correctRotation = true;
                }
                else if (collision.transform.rotation.z < rotationMin || collision.transform.rotation.z > rotationMax)
                {
                    correctRotation = false;
                }
           }
           else
            {
                return;
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            pieceInCorrectSlot = false;
            pieceInSlot = false;
            correctRotation = false;
        }
    }
}
