using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public bool draggable = false;
    public bool isUsed = false;
    public bool canBeUsed = false;
   

    public GameObject selectedObject;
    public Vector3 inventoryPos;

    public void RecordInventoryPos()
    {
        inventoryPos = this.transform.position;
        Debug.Log("key position: " + inventoryPos);
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
