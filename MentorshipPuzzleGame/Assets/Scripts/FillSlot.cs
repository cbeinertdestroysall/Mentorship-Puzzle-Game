using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillSlot : MonoBehaviour
{
    public bool slotIsFilled = false;

    
    public bool pieceAlreadyInSlot;

    public GameObject mainFunctionality;

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
        if (collision.gameObject.tag == "Item")
        {
            Debug.Log("item has entered inventory");
            if (slotIsFilled == false)
            {
                slotIsFilled = true;
               
            }
            else
            {
                pieceAlreadyInSlot = true;
                //collision.transform.position = collision.GetComponent<InventoryPosition>().inventoryPos;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Debug.Log("item has left inventory");
            if (pieceAlreadyInSlot == false)
            {
                mainFunctionality.GetComponent<InventoryReSystem>().DecreaseSlotNumber();
                slotIsFilled = false;
            }
            else
            {
                slotIsFilled = true;
                pieceAlreadyInSlot = false;
            }
        }
    }
}
