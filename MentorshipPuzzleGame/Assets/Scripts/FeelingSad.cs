using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FeelingSad : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject signifierText;

    public bool isHovering = false;
    public bool keyDown = false;

    public Vector3 offset;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
        signifierText.SetActive(true);
        isHovering = true;
        //signifierText.transform.position = Input.mousePosition;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");
        signifierText.SetActive(false);
        isHovering = false;
    }

    private void Update()
    {
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
}
