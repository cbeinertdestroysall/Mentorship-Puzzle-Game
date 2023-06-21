using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerLevels : MonoBehaviour
{
    public float powerLevel = 1;

    public GameObject[] backgrounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            powerLevel = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            powerLevel = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            powerLevel = 3;
        }

        foreach (GameObject background in backgrounds)
        {
            if (powerLevel == 1)
            {
                background.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if (powerLevel == 2)
            {
                background.GetComponent<Image>().color = new Color32(255, 112, 112, 255);
            }
            else if (powerLevel == 3)
            {
                background.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            }
        }
    }
}
