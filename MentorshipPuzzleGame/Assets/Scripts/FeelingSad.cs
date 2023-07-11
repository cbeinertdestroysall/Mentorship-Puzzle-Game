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

        if (isHovering)
        {
            signifierText.transform.position = Input.mousePosition + offset;
        }
        else
        {
            signifierText.transform.position = this.transform.position;
        }
    }
}
