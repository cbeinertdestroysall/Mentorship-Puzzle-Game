using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MaskFollowingMouse : MonoBehaviour
{
    Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        this.GetComponent<RectTransform>().anchoredPosition = mousePos;

        //Debug.Log("mouse Pos = " + mousePos);
        //Debug.Log("mask position = " + this.GetComponent<RectTransform>().anchoredPosition);
    }
}
