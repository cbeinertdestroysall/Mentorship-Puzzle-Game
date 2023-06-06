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
        if (mainFunctionality.GetComponent<InventoryReSystem>().slotNumber == 1)
        {
            Debug.Log("item added 1");
            item.transform.position = slot1.transform.position;
            item.transform.SetParent(slot1.transform.parent, true);
        }
        else if (mainFunctionality.GetComponent<InventoryReSystem>().slotNumber == 2)
        {
            Debug.Log("item added 2");
            item.transform.position = slot2.transform.position;
            item.transform.SetParent(slot2.transform.parent, true);
        }
        else if (mainFunctionality.GetComponent<InventoryReSystem>().slotNumber == 3)
        {
            Debug.Log("item added 3");
            item.transform.position = slot3.transform.position;
            item.transform.SetParent(slot3.transform.parent, true);
        }
    }

   
}
