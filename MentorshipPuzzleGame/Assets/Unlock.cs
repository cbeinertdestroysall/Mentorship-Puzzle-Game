using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour
{
    public GameObject key;
    public Sprite unlocked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (key == null)
        {
            this.GetComponent<Image>().sprite = unlocked;
        }
    }
}
