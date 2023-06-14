using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceScript : MonoBehaviour
{
    //public InventoryReSystem inventory;

    //public UiDrag ui;

    public float puzzleNumber;

    public GameObject mainFunctionality;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryReSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot")
        {

            this.GetComponent<InventoryPosition>().inventoryPos = collision.gameObject.GetComponent<BoxCollider2D>().transform.position;

            this.transform.SetParent(collision.transform.parent, true);
            //inventory.DecreaseSlotNumber();
        }
        else if (collision.gameObject.tag == "Inventory")
        {
            if (collision.GetComponent<FillSlot>().slotIsFilled == false)
            {
                this.GetComponent<InventoryPosition>().inventoryPos = collision.gameObject.GetComponent<BoxCollider2D>().transform.position;
                collision.GetComponent<FillSlot>().slotIsFilled = true;
                this.transform.SetParent(collision.transform.parent, true);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" && mainFunctionality.GetComponent<UiDrag>().dragging == false)
        {
            this.transform.SetParent(collision.transform.parent, true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inventory")
        {
            mainFunctionality.GetComponent<InventoryReSystem>().DecreaseSlotNumber();
            collision.GetComponent<FillSlot>().slotIsFilled = false;
        }
    }

}