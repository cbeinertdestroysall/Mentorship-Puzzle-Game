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

    public bool pieceAlreadyInSlot;

    GameObject puzzlePiece;

    public WindowScript windowScript;

    public GameObject noiseMaker;

    //public AudioSource click;

    IEnumerator SetToFalse()
    {
        yield return new WaitForSeconds(1f);
        pieceAlreadyInSlot = false;
    }

    /*IEnumerator ActivateAudio()
    {
        yield return new WaitForSeconds(0.5f);
        //click.gameObject.SetActive(true);
    }*/

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
        if (collision.gameObject.tag == "Puzzle Piece") //if an object tagged puzzle piece enters a slot
        {
            if (pieceInSlot == false) //and if a piece isn't already in the slot
            {
                pieceInSlot = true; //then a piece is in the slot
                pieceAlreadyInSlot = false; //but a piece isn't "already" in the slot
                puzzlePiece = collision.gameObject;
                

                noiseMaker.GetComponent<AudioSource>().Play();

                if (collision.GetComponent<PuzzlePieceScript>().puzzleNumber == slotNumber)
                {
                    pieceInCorrectSlot = true;

                }
                else
                {
                    pieceInCorrectSlot = false;
                }

                if (this.GetComponent<RotateObject>() != null)
                {
                    UpdateRotationData();
                }
                else 
                {
                    return;
                }


            }
            else //if a puzzle piece is in a slot then a piece is "already" in the slot
            {
                pieceAlreadyInSlot = true;
                return;
            }
        }

        if (collision.gameObject.tag == "Item") //if an object tagged "item" enters a slot 
        {
            
            if (pieceInSlot == true) //an a piece can be found in that slot 
            {
                pieceAlreadyInSlot = true; //then a piece is already in the slot and end the method early
                return;

            }
            else //but if a piece isn't in a slot
            {
                pieceAlreadyInSlot = false; //then a piece isn't already in the slot
                
            }
        
        }
                
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            if (pieceInSlot == false)
            {
                pieceInSlot = true;
                pieceAlreadyInSlot = false;
                

                if (this.GetComponent<RotateObject>() != null)
                {
                    UpdateRotationData();
                }
                else
                {
                    return;
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
        if (collision.gameObject.tag == "Item") //if an object tagged "item" has exited
        {
            if (pieceAlreadyInSlot == true) //and if a piece is already in the slot
            {
                pieceInSlot = true; //a piece is still in the slot
                pieceAlreadyInSlot = false; //but a piece isn't "already" in the slot (which is meant to prevent objects from being unable to enter slots when they're empty)
                return;
            }
            else if (pieceAlreadyInSlot == false)
            {
                pieceInCorrectSlot = false;
                pieceInSlot = false;
                correctRotation = false;

                puzzlePiece = null;

                Debug.Log("piece isn't in a slot");
            }
        }

        if (collision.gameObject.tag == "Puzzle Piece")
        {
            if (pieceAlreadyInSlot == true)
            {
                pieceInSlot = true;

                StartCoroutine(SetToFalse());

                Debug.Log("piece is already in the slot!");

                return;
            }
            else if (pieceAlreadyInSlot == false)
            {
                pieceInCorrectSlot = false;
                pieceInSlot = false;
                correctRotation = false;
                collision.gameObject.GetComponent<ItemScript>().canBeUsed = false;

                puzzlePiece = null;

                Debug.Log("piece isn't in a slot");
            }
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
