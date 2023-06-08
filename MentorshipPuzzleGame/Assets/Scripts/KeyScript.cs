using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public UiDrag uiDrag;
    //public AudioSource aus;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && uiDrag.dragging)
        {
            Debug.Log("Key can enter lock");
            this.GetComponent<ItemScript>().canBeUsed = true;
            this.GetComponent<ItemScript>().inventoryPos = this.transform.position;
        }
        else if (collision.gameObject.tag == "Lock" && uiDrag.dragging == false)
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
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
