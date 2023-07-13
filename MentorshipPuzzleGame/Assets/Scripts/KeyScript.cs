using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public UiDrag uiDrag;
    public AudioSource aus;
    public AudioClip audioClip;

    public bool isCollidingWithInventory;

    public GameObject use;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Destroy()
    {
        //this.GetComponent<ItemScript>().canBeUsed = false;
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && this.GetComponent<ItemScript>().canBeUsed)
        {
            // Debug.Log("key entered lock");
            this.GetComponent<InventoryPosition>().inventoryPos = this.transform.position;
            use.gameObject.SetActive(true);
            //this.GetComponent<ItemScript>().isUsed = true;
            //aus.clip = audioClip;
            //aus.Play();
        }

        else if (collision.gameObject.tag == "Inventory")
        {
            isCollidingWithInventory = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && uiDrag.dragging == false && this.GetComponent<ItemScript>().canBeUsed)
        {
            //Debug.Log("key has disappeared");
            anim.SetBool("Used", true);
            use.gameObject.SetActive(false);
            //this.GetComponent<InventoryPosition>().inventoryPos = this.transform.position;
            //AudioSource.PlayClipAtPoint(audioClip, transform.position, 1f);
            StartCoroutine(Destroy());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock")
        {
            this.GetComponent<ItemScript>().isUsed = false;
            use.gameObject.SetActive(false);
        }
        /*else if (collision.gameObject.tag == "Inventory")
        {
            this.GetComponent<ItemScript>().canBeUsed = false;
        }*/
    }
}
