using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerLevels : MonoBehaviour
{
    public float powerLevel = 1;

    public GameObject[] backgrounds;

    public GameObject[] meltables;

    public float currentHealth;

    public HealthBar healthBar;

    public GameObject noiseMaker;

    public GameObject signifier1;

    public GameObject signifier2;

    public bool mode1Activated = false;

    public bool mode2Activated = false;

    public GameObject press1;
    public GameObject press2;

    IEnumerator DestroyTutorial()
    {
        yield return new WaitForSeconds(1);
        Destroy(press1);
        Destroy(press2);
        //Debug.Log("tutorial is destroyed");
    }

    //public GameObject meltCollider;

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
            noiseMaker.SetActive(false);
            mode1Activated = true;

            if (mode1Activated && mode2Activated && press1 != null && press2 != null)
            {
                StartCoroutine(DestroyTutorial());
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (currentHealth <= 0)
            {
                /*foreach (GameObject meltable in meltables)
                {
                    if (meltable != null)
                    meltable.GetComponent<Animator>().speed = 0;
                }*/
                powerLevel = 1;
                //noiseMaker.SetActive(false);
            }
            else
            {
                powerLevel = 2;
                //noiseMaker.SetActive(true);
            }
            mode2Activated = true;

            if (mode1Activated && mode2Activated && press1 != null && press2 != null)
            {
                StartCoroutine(DestroyTutorial());
            }
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
        }
        healthBar.SetHealth(currentHealth);

    }

    public void RegenerateHealth()
    {
        currentHealth = 100;
        healthBar.SetHealth(currentHealth);
    }

    private void FixedUpdate()
    {
        if (powerLevel == 1)
        {
            currentHealth += 0;
            healthBar.SetHealth(currentHealth);
            this.GetComponent<CircleCollider2D>().enabled = false;
            noiseMaker.SetActive(false);

            signifier1.GetComponent<Image>().color = new Color(255, 0, 0);
            signifier2.GetComponent<Image>().color = new Color(255, 255, 255);
        }
        else if (powerLevel == 2)
        {
            currentHealth -= 0.5f;
            healthBar.SetHealth(currentHealth);
            this.GetComponent<CircleCollider2D>().enabled = true;
            noiseMaker.SetActive(true);

            signifier1.GetComponent<Image>().color = new Color(255, 255, 255);
            signifier2.GetComponent<Image>().color = new Color(255, 0, 0);
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

    public void ResetMeltableAnimation()
    {
        foreach (GameObject meltable in meltables)
        {
            if (meltable != null)
            {
                meltable.GetComponent<MeltableObject>().ResetAnimation();
            }
        }
    }
}
