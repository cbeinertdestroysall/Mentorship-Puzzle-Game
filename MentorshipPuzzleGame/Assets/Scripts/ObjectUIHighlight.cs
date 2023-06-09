using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUIHighlight : MonoBehaviour
{
    public GameObject highlight;

    //public Sprite unlocked;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item" && highlight != null)
        {
            highlight.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            highlight.gameObject.SetActive(false);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            highlight.gameObject.SetActive(true);
        }
    }*/

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item" && highlight != null)
        {
            highlight.gameObject.SetActive(false);
        }
    }

    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            highlight.gameObject.SetActive(false);
        }
    }*/

}
