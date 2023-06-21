using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerLevels : MonoBehaviour
{
    public float powerLevel = 1;

    public GameObject[] backgrounds;

    public float currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        //healthBar.SetHealth(health);
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
        healthBar.SetHealth(currentHealth);
    }

    private void FixedUpdate()
    {
        if (powerLevel == 1)
        {
            currentHealth += 1;
            healthBar.SetHealth(currentHealth);
        }
        else if (powerLevel == 2)
        {
            currentHealth -= 0.5f;
            healthBar.SetHealth(currentHealth);
        }
        else if (powerLevel == 3)
        {
            currentHealth -= 1;
            healthBar.SetHealth(currentHealth);
        }

        if (currentHealth >= 100)
        {
            currentHealth = 100;
            healthBar.SetHealth(currentHealth);
        } 
        else if (currentHealth <= 0)
        {
            powerLevel = 1;
        }
    }
}
