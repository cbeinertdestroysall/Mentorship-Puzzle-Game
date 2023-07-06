using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class UiDrag : MonoBehaviour
{
    public GameObject uiCanvas;
    GraphicRaycaster uiRaycaster;
    PointerEventData clickData;
    List<RaycastResult> clickResults;

    public GameObject noiseMaker;

    List<GameObject> clickedElements;

    public bool dragging = false;
    GameObject dragElement;

    Vector3 mousePosition;
    Vector3 previousMousePosition;

    public SoundManager soundM;

    IEnumerator ReturnToInventory()
    {
        yield return new WaitForSeconds(0.1f);
        dragElement.transform.position = dragElement.gameObject.GetComponent<InventoryPosition>().inventoryPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        uiRaycaster = uiCanvas.GetComponent<GraphicRaycaster>();
        clickData = new PointerEventData(EventSystem.current);
        clickResults = new List<RaycastResult>();
        clickedElements = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseDragUI();
    }

    void MouseDragUI()
    {
        mousePosition = Mouse.current.position.ReadValue();

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DetectUi();
        }

        //main dragging functionality
        if (Mouse.current.leftButton.isPressed && dragging)
        {
            if (dragElement.gameObject.GetComponent<ItemScript>() == null)
            {
                dragging = false;
            }
            else
            {
                if (dragElement.gameObject.GetComponent<ItemScript>().draggable)
                {
                    
                    if (dragElement.gameObject.GetComponent<BoxCollider2D>() != null)
                    {
                        DragElement();
                        dragElement.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    else 
                    {
                        DragElement();
                        noiseMaker.gameObject.SetActive(true);
                       
                    }
                }
                else
                {
                    dragging = false;
                    //soundManager.StopDraggingSound();
                    dragElement = null;
                }
            }
        }
        else if (Mouse.current.leftButton.isPressed && dragElement == null)
        {
            dragging = false;
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            dragging = false;

            if (dragElement.gameObject.GetComponent<InventoryPosition>() == null && noiseMaker != null)
                noiseMaker.gameObject.SetActive(false);

            //Debug.Log("dragging = " + dragging);

            if (dragElement.gameObject.GetComponent<ItemScript>() != null && dragElement.gameObject.GetComponent<InventoryPosition>() != null)
            {
                dragElement.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                //soundM.PlayError();
                StartCoroutine(ReturnToInventory());

                if (dragElement.gameObject.GetComponent<ItemScript>().canBeUsed == false)
                {
                    Debug.Log("wrong place");
                    //Debug.Log("current object position " + dragElement.gameObject.transform.position);
                    soundM.PlayError();
                }
                else 
                {
                    Debug.Log("right place");
                }
                
            }
            else 
            {
                return;
            }
           
        }
        
        previousMousePosition = mousePosition;
    }

    void DetectUi()
    {
        GetUIElementsClicked();

        if (clickedElements.Count > 0)
        {
            dragging = true;
            dragElement = clickedElements[0];
        }
    }

    void GetUIElementsClicked()
    {
        clickData.position = mousePosition;
        clickResults.Clear();
        uiRaycaster.Raycast(clickData, clickResults);

        clickedElements.Clear();
        foreach (RaycastResult result in clickResults)
        {
            clickedElements.Add(result.gameObject);
        }
    }

    //where the dragging game object magic is supposed to happen
    void DragElement()
    {
        RectTransform elementRect = dragElement.GetComponent<RectTransform>();

        Vector2 dragMovement = mousePosition - previousMousePosition;

        elementRect.anchoredPosition = elementRect.anchoredPosition + (dragMovement/elementRect.parent.lossyScale);
    }
}
