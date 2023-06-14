using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemReScript : MonoBehaviour
{
    public GameObject item;
    public GameObject mainFunctionality;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;

    public GameObject[] slots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItemToSlot()
    {
       
        for (int i = 0; i < slots.Length; i++)
        {
            if (i == mainFunctionality.GetComponent<InventoryReSystem>().slotNumber && slots[i].GetComponent<FillSlot>().slotIsFilled == false)
            {
                Debug.Log("item added " + mainFunctionality.GetComponent<InventoryReSystem>().slotNumber);
                item.transform.position = slots[i].transform.position;
                slots[i].GetComponent<FillSlot>().slotIsFilled = true;
                item.transform.SetParent(slots[i].transform.parent, true);
                item.GetComponent<ItemScript>().draggable = true;
            }
            else if (i == mainFunctionality.GetComponent<InventoryReSystem>().slotNumber && slots[i].GetComponent<FillSlot>().slotIsFilled == true)
            {
                if (i < slots.Length)
                {
                    mainFunctionality.GetComponent<InventoryReSystem>().IncreaseSlotNumber();
                }
                else if (i >= slots.Length)
                {
                    mainFunctionality.GetComponent<InventoryReSystem>().DecreaseSlotNumber();
                }
            
                  

            }


        }
     
    }

   
}
