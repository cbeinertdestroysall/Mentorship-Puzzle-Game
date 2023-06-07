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

    List<GameObject> clickedElements;

    bool dragging = false;
    GameObject dragElement;

    Vector3 mousePosition;
    Vector3 previousMousePosition;

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
        if (Mouse.current.leftButton.isPressed && dragging && dragElement.gameObject.GetComponent<ItemScript>().draggable)
        {
            DragElement();
        }
        else 
        {
            dragging = false;
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

    void DragElement()
    {
        RectTransform elementRect = dragElement.GetComponent<RectTransform>();

        Vector2 dragMovement = mousePosition - previousMousePosition;

        elementRect.anchoredPosition = elementRect.anchoredPosition + dragMovement;
    }
}