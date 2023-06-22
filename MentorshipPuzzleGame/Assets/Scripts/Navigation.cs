using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;

    public GameObject[] backgrounds;

    public int currentBackgroundView;

    public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            if (i == currentBackgroundView)
            {
                backgrounds[i].SetActive(true);
            }
            else 
            {
                backgrounds[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void ShiftLeft()
    {
        if (currentBackgroundView > 0)
        {
            currentBackgroundView -= 1;
        }
        else if (currentBackgroundView == 0)
        {
            currentBackgroundView = 3;
        }

        for (int i = 0; i < backgrounds.Length; i++)
        {
            if (i == currentBackgroundView)
            {
                backgrounds[i].SetActive(true);
            }
            else
            {
                backgrounds[i].SetActive(false);
            }
        }

        if (currentBackgroundView == 2 && flashlight != null)
        {
            flashlight.SetActive(false);
        }
        else 
        {
            flashlight.SetActive(true);
        }
    }

    public void ShiftRight()
    {
        if (currentBackgroundView < 3)
        {
            currentBackgroundView += 1;
        }
        else if (currentBackgroundView == 3)
        {
            currentBackgroundView = 0;
        }

        for (int i = 0; i < backgrounds.Length; i++)
        {
            if (i == currentBackgroundView)
            {
                backgrounds[i].SetActive(true);
            }
            else
            {
                backgrounds[i].SetActive(false);
            }
        }

        if (currentBackgroundView == 2 && flashlight != null)
        {
            flashlight.SetActive(false);
        }
        else
        {
            flashlight.SetActive(true);
        }
    }
}
