using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryReSystem : MonoBehaviour
{
    public int slotNumber = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseSlotNumber()
    {
        if (slotNumber < 3)
        {
            slotNumber++;
            Debug.Log("slot number: " + slotNumber);
        }
        else 
        {
            Debug.Log("You have too many items in your inventory");
        }
    }
}
