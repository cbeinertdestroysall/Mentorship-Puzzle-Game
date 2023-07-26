using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillSlot : MonoBehaviour
{
    public bool slotIsFilled = false;

    [SerializeField]
    bool pieceAlreadyInSlot;

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
            if (slotIsFilled == false)
            {
                slotIsFilled = true;
                collision.GetComponent<InventoryPosition>().inventoryPos = this.gameObject.GetComponent<BoxCollider2D>().transform.position;
               
                //collision.transform.SetParent(collision.transform.parent, true);
            }
            else
            {
                pieceAlreadyInSlot = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            if (pieceAlreadyInSlot == false)
            {
                //mainFunctionality.GetComponent<InventoryReSystem>().DecreaseSlotNumber();
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
