using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSlotScript : MonoBehaviour
{
    public float slotNumber;

    public bool pieceInCorrectSlot = false;

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
            if (collision.GetComponent<PuzzlePieceScript>().puzzleNumber == slotNumber)
            {
                pieceInCorrectSlot = true;
            }
            else 
            {
                pieceInCorrectSlot = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            pieceInCorrectSlot = false;
        }
    }
}
