using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject testObject;
    public AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateObject90Degrees()
    {
        testObject.transform.Rotate(0, 0, 90f);
        audioS.Play();
    }
}
