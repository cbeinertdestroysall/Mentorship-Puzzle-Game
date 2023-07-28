using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingObject : MonoBehaviour
{
    public Sprite frozen;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Animator>().speed > 0)
        {
            this.GetComponent<Image>().sprite = null;
        }
        else
        {
            this.GetComponent<Image>().sprite = frozen;
        }
    }
}
