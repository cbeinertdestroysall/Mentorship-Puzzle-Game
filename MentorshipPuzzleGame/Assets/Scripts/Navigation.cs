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
        //backgrounds[currentBackgroundView];

        /*foreach (GameObject background in backgrounds)
        { 
            
        }*/

        /*if (currentBackgroundView == 0)
        {
            background1.SetActive(true);
            background2.SetActive(false);
            background3.SetActive(false);
            background4.SetActive(false);
        }
        else if (currentBackgroundView == 1)
        {
            background1.SetActive(false);
            background2.SetActive(true);
            background3.SetActive(false);
            background4.SetActive(false);
        }
        else if (currentBackgroundView == 2)
        {
            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(true);
            background4.SetActive(false);
        }
        else if (currentBackgroundView == 3)
        {
            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(false);
            background4.SetActive(true);
        }*/

        


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
    }
}
