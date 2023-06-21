using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerLevels : MonoBehaviour
{
    public float powerLevel = 1;

    public GameObject[] backgrounds;

    public float health;

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

    private void FixedUpdate()
    {
        if (powerLevel == 1)
        {
            health += 1;
        }
        else if (powerLevel == 2)
        {
            health -= 0.5f;
        }
        else if (powerLevel == 3)
        {
            health -= 1;
        }

        if (health >= 100)
        {
            health = 100;
        } 
        else if (health <= 0)
        {
            powerLevel = 1;
        }
    }
}
