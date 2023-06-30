using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSlotScript : MonoBehaviour
{
    public float slotNumber;

    public bool pieceInCorrectSlot = false;

    public bool pieceInSlot = false;

    public bool correctRotation = false;

    public float rotationMin;
    public float rotationMax;

    public float altRotationMin;

    GameObject puzzlePiece;

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
            if (pieceInSlot == true)
            {
                return;
            }
            else 
            { 
            pieceInSlot = true;
            puzzlePiece = collision.gameObject;
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
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            if (pieceInSlot == true)
            {
                return;
            }
            else
            {
                pieceInSlot = true;

                if (this.GetComponent<RotateObject>() != null)
                {
                    UpdateRotationData();
                }
                else
                {
                    return;
                }
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

            puzzlePiece = null;
        }
    }

    public void UpdateRotationData()
    {
        if (puzzlePiece == null)
        {
            Debug.Log("puzzle piece is null!!!!!!");
            return;
        }
        else if (puzzlePiece.transform.rotation.eulerAngles.z >= rotationMin && puzzlePiece.transform.rotation.eulerAngles.z <= rotationMax || puzzlePiece.transform.rotation.eulerAngles.z > altRotationMin)
        {
            correctRotation = true;
        }
        else if (puzzlePiece.transform.rotation.eulerAngles.z < rotationMin || puzzlePiece.transform.rotation.eulerAngles.z > rotationMax || puzzlePiece.transform.rotation.eulerAngles.z < altRotationMin)
        {
            correctRotation = false;
        }
    }
}
