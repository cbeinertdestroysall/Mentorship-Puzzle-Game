using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject testObject;
    public AudioSource audioS;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateObject90Degrees()
    {
        if (this.GetComponent<WindowSlotScript>().pieceInSlot)
        {
            testObject.transform.Rotate(0, 0, 90f);
            audioS.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle Piece")
        {
            testObject = collision.gameObject;
        }
    }
}
