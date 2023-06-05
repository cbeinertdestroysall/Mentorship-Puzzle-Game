using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (mousePos == this.gameObject.transform.position)
        {
            Debug.Log("mouse is on gameobject");
        }

        //Debug.Log("MouseX " + mousePos.x);
        //Debug.Log("MouseY " + mousePos.y);
    }
}
