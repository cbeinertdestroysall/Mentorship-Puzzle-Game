using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    Vector3 startPos;
    public GameObject tutorialText;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position != startPos)
        {
            tutorialText.SetActive(false);
        }
    }
}
