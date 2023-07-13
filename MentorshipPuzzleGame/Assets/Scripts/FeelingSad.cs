using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FeelingSad : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject signifierText;

    //public GameObject leftButton;
   // public GameObject rightButton;

    public bool isHovering = false;
    public bool keyDown = false;

    public bool awayFromInventory = true;

    public Vector3 offset;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
     
            Debug.Log("Cursor Entering " + name + " GameObject");
            
            isHovering = true;
           
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (signifierText != null)
        {
            Debug.Log("Cursor Exiting " + name + " GameObject");
            signifierText.SetActive(false);
            isHovering = false;
        }
        
    }

    void OnDisable()
    {
        isHovering = false;
        keyDown = false;
    }

    

    private void Update()
    {
        //offset = new Vector3(81.69f, 13.01f, 0);

        if (this == null)
        {
            Destroy(signifierText);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            keyDown = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            keyDown = false;
        }
        if (signifierText != null) { 
        if (isHovering && keyDown == false)
        {
            signifierText.transform.position = Input.mousePosition + offset;
            signifierText.SetActive(true);
        }
        else if (isHovering && keyDown)
        {
            //signifierText.transform.position = this.transform.position;
            signifierText.SetActive(false);
        }



            if (this.GetComponent<InventoryPosition>() != null)
            {
                if (this.GetComponent<ItemScript>().draggable == true)
                {
                    if (isHovering && keyDown == false)
                    {
                        signifierText.transform.position = Input.mousePosition + offset;
                        signifierText.SetActive(true);
                    }
                    else if (isHovering && keyDown)
                    {
                        //signifierText.transform.position = this.transform.position;
                        signifierText.SetActive(false);
                    }
                }
                else
                {
                    signifierText.SetActive(false);
                }

                /*if (this.transform.position != this.GetComponent<InventoryPosition>().inventoryPos)
                {
                    awayFromInventory = true;
                }
                else
                {
                    awayFromInventory = false;
                }*/

                if (this.GetComponent<ItemScript>().draggable == true && awayFromInventory == true)
                {
                    signifierText.SetActive(false);
                }
                else if (this.GetComponent<ItemScript>().draggable == false)
                {
                    signifierText.SetActive(false);
                }
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inventory" && this.GetComponent<InventoryPosition>() != null)
        {
            awayFromInventory = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inventory" && this.GetComponent<InventoryPosition>() != null)
        {
            awayFromInventory = true;
        }
    }
}
