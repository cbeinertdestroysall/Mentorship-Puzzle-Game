using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class FreezeFlashlight : MonoBehaviour
{
    public bool freezeMode;

    public GameObject unfreeze;
    public GameObject freeze;

    public GameObject lens;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Input.mousePosition;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            freezeMode = false;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            freezeMode = true;
        }

        if (freezeMode == false)
        {
            unfreeze.GetComponent<Image>().color = new Color(255, 0, 0);
            freeze.GetComponent<Image>().color = new Color(255, 255, 255);
            lens.GetComponent<Image>().color = new Color(255, 118, 96, 54);
        }
        else 
        {
            unfreeze.GetComponent<Image>().color = new Color(255, 255, 255);
            freeze.GetComponent<Image>().color = new Color(255, 0, 0);
            lens.GetComponent<Image>().color = new Color(95, 240, 255, 54);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MovingObject" && freezeMode)
        {
            collision.gameObject.GetComponent<Animator>().speed = 0;
        }
        else if (collision.gameObject.tag == "MovingObject" && freezeMode == false)
        {
            collision.gameObject.GetComponent<Animator>().speed = 1;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MovingObject" && freezeMode)
        {
            collision.gameObject.GetComponent<Animator>().speed = 0;
        }
        else if (collision.gameObject.tag == "MovingObject" && freezeMode == false)
        {
            collision.gameObject.GetComponent<Animator>().speed = 1;
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MovingObject")
        {
            collision.gameObject.GetComponent<Animator>().speed = 1;
        }
    }*/
}
