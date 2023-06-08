using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public UiDrag uiDrag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<ItemScript>().canBeUsed)
        {
            this.GetComponent<ItemScript>().inventoryPos = this.transform.position;
        }

        if (this.GetComponent<ItemScript>().canBeUsed && uiDrag.dragging == false)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && uiDrag.dragging)
        {
            
                Debug.Log("Key can enter lock");
                this.GetComponent<ItemScript>().canBeUsed = true;
                
            
            
        }
        else if (collision.gameObject.tag == "Lock" && uiDrag.dragging == false)
        {
            this.GetComponent<ItemScript>().used = true;
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock")
        {
            this.GetComponent<ItemScript>().canBeUsed = false;
        }
    }
}
