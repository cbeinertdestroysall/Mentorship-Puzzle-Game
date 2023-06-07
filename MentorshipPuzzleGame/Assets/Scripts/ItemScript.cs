using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public bool draggable = false;

    public GameObject selectedObject;
    public Vector3 inventoryPos;
    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecordInventoryPos()
    {
        inventoryPos = this.transform.position;
    }
}
