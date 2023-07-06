using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPosition : MonoBehaviour
{
    public Vector3 inventoryPos;

    public void RecordInventoryPos()
    {
        inventoryPos = this.transform.position;
        //Debug.Log("key position: " + inventoryPos);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
