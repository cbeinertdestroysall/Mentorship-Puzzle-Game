using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    /*public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;*/

    public GameObject[] backgrounds;
    public GameObject[] backgrounds2;

    public int currentBackgroundView;
    public int currentBackgroundView2;

    public GameObject flashlight;

    public GameObject meltCollider;

    public GameObject[] flashlightComponents;

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

        if (backgrounds2 != null)
        {
            for (int i = 0; i < backgrounds2.Length; i++)
            {
                if (i == currentBackgroundView2)
                {
                    backgrounds2[i].SetActive(true);
                }
                else
                {
                    backgrounds2[i].SetActive(false);
                }
            }
        }
    }

    private void Awake()
    {
        //Cursor.lockState = CursorLockMode.Confined;
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
            currentBackgroundView = backgrounds.Length - 1;
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

        if (flashlight != null)
        {
            if (currentBackgroundView == 2)
            {
                meltCollider.GetComponent<PowerLevels>().powerLevel = 1;

                foreach (GameObject flashlight in flashlightComponents)
                {
                    flashlight.GetComponent<Image>().enabled = false;
                }
                //flashlight.SetActive(false);

            }
            else
            {
                //meltCollider.GetComponent<PowerLevels>().powerLevel = 1;

                foreach (GameObject flashlight in flashlightComponents)
                {
                    flashlight.GetComponent<Image>().enabled = true;
                }
                //flashlight.SetActive(true);
            }
        }
    }

    public void ShiftLeft2()
    {
        if (currentBackgroundView2 > 0)
        {
            currentBackgroundView2 -= 1;
        }
        else if (currentBackgroundView2 == 0)
        {
            currentBackgroundView2 = backgrounds2.Length - 1;
        }

        for (int i = 0; i < backgrounds2.Length; i++)
        {
            if (i == currentBackgroundView2)
            {
                backgrounds2[i].SetActive(true);
            }
            else
            {
                backgrounds2[i].SetActive(false);
            }
        }
    }

    public void ShiftRight()
    {
        if (currentBackgroundView < backgrounds.Length - 1)
        {
            currentBackgroundView += 1;
        }
        else if (currentBackgroundView >= (backgrounds.Length - 1))
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

        if (flashlight != null)
        {
            if (currentBackgroundView == 2)
            {
                meltCollider.GetComponent<PowerLevels>().powerLevel = 1;

                foreach (GameObject flashlight in flashlightComponents)
                {
                    flashlight.GetComponent<Image>().enabled = false;
                }
                //flashlight.SetActive(false);
                
            }
            else
            {
                //meltCollider.GetComponent<PowerLevels>().powerLevel = 1;

                foreach (GameObject flashlight in flashlightComponents)
                {
                    flashlight.GetComponent<Image>().enabled = true;
                }
                //flashlight.SetActive(true);
            }
        }
    }

    public void ShiftRight2()
    {
        if (currentBackgroundView2 < backgrounds2.Length - 1)
        {
            currentBackgroundView2 += 1;
        }
        else if (currentBackgroundView2 >= (backgrounds2.Length - 1))
        {
            currentBackgroundView2 = 0;
        }

        for (int i = 0; i < backgrounds2.Length; i++)
        {
            if (i == currentBackgroundView2)
            {
                backgrounds2[i].SetActive(true);
            }
            else
            {
                backgrounds2[i].SetActive(false);
            }
        }
    }
}
