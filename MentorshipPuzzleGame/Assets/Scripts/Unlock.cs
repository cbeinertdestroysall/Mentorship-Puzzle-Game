using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour
{
    public GameObject key;
    public Sprite unlocked;

    public AudioSource audioS;
    public AudioClip audioC;

    public UiDrag uiDrag;

    public float gravity;

    //public SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (key != null)
        {
            if (key.GetComponent<ItemScript>().isUsed)
            {
                this.GetComponent<Image>().sprite = unlocked;
                
                //audioS.PlayOneShot(audioC);
            }
        }
        else 
        {
            return;
        }

        //if (uiDrag.clickedElements == this.gameObject)

        /*if (soundCanPlay)
        {
            audioS.PlayOneShot(audioC);
            soundCanPlay = false;
        }
        else 
        {
            audioS.Stop();
        }*/

        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key" && key.GetComponent<ItemScript>().canBeUsed)
        {
            if (key != null)
            {
                Debug.Log("key entered lock");
                key.GetComponent<InventoryPosition>().inventoryPos = key.transform.position;
                key.GetComponent<ItemScript>().isUsed = true;
                this.GetComponent<Image>().sprite = unlocked;

                this.GetComponent<Rigidbody2D>().gravityScale = gravity;
                this.GetComponent<BoxCollider2D>().isTrigger = false;

                audioS.clip = audioC;
                audioS.Play();
            }
        }
    }





}
