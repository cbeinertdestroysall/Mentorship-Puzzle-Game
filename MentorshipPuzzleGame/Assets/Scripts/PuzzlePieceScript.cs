using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceScript : MonoBehaviour
{
    //public InventoryReSystem inventory;

    //public UiDrag ui;

    public float puzzleNumber;

    public GameObject mainFunctionality;

    public float inventoryScale;

    public float slotScale;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation.eulerAngles = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" && collision.GetComponent<WindowSlotScript>().pieceInSlot == false)
        {

            this.GetComponent<InventoryPosition>().inventoryPos = collision.gameObject.GetComponent<BoxCollider2D>().transform.position;

            this.transform.SetParent(collision.transform.parent, true);

            this.transform.localScale = new Vector3(slotScale, slotScale, slotScale);
            
            
        }
        else if (collision.gameObject.tag == "Inventory")
        {
            if (collision.GetComponent<FillSlot>().slotIsFilled == false)
            {
                this.GetComponent<InventoryPosition>().inventoryPos = collision.gameObject.GetComponent<BoxCollider2D>().transform.position;
                collision.GetComponent<FillSlot>().slotIsFilled = true;
                this.transform.SetParent(collision.transform.parent, true);
                this.transform.localScale = new Vector3(inventoryScale, inventoryScale, inventoryScale);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" && mainFunctionality.GetComponent<UiDrag>().dragging == false)
        {
            //where the problem seems to be happening
            this.transform.SetParent(collision.transform.parent, true);
            this.transform.localScale = new Vector3(slotScale, slotScale, slotScale);
            this.gameObject.GetComponent<ItemScript>().canBeUsed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inventory")
        {
            mainFunctionality.GetComponent<InventoryReSystem>().DecreaseSlotNumber();
            collision.GetComponent<FillSlot>().slotIsFilled = false;
            this.transform.SetParent(collision.transform.parent, true);
            this.transform.localScale = new Vector3(inventoryScale, inventoryScale, inventoryScale);
        }
        else if (collision.gameObject.tag == "Slot")
        {
            this.transform.SetParent(collision.transform.parent, true);
            this.transform.localScale = new Vector3(slotScale, slotScale, slotScale);
        }
    }

}
