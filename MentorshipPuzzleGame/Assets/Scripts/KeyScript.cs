using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public UiDrag uiDrag;
    public AudioSource aus;
    public AudioClip audioClip;

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
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && this.GetComponent<ItemScript>().canBeUsed)
        {
            Debug.Log("key entered lock");
            this.GetComponent<ItemScript>().inventoryPos = this.transform.position;
            this.GetComponent<ItemScript>().isUsed = true;
            aus.clip = audioClip;
            aus.Play();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock" && uiDrag.dragging)
        {
            //Debug.Log("Key can enter lock");
            this.GetComponent<ItemScript>().isUsed = true;
            this.GetComponent<ItemScript>().inventoryPos = this.transform.position;
        }
        else if (collision.gameObject.tag == "Lock" && uiDrag.dragging == false && this.GetComponent<ItemScript>().canBeUsed)
        {
            //Debug.Log("key has disappeared");
            anim.SetBool("Used", true);
            AudioSource.PlayClipAtPoint(audioClip, transform.position, 1f);
            StartCoroutine(Destroy());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lock")
        {
            this.GetComponent<ItemScript>().isUsed = false;
        }
    }
}
