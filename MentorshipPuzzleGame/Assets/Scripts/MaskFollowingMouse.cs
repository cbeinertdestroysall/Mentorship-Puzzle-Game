using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MaskFollowingMouse : MonoBehaviour
{
    Vector2 mousePos;
    Vector3 previousMousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();

        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.GetComponent<RectTransform>().anchoredPosition = mousePos;
    }
}
