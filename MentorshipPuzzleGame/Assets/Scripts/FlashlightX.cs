using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class FlashlightX : MonoBehaviour
{
    Vector2 mousePos;
    //Vector2 currentPos;

    

    public Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        //currentPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        //currentPos = Camera.main.ScreenToWorldPoint(this.transform.position);

        this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y) + offset;

        
    }
}
