using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltableObject : MonoBehaviour
{
    public Animator anim;

    public AudioSource audioS;

    public float countdownToDestruction;

    public bool canAnimate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.speed = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.speed = 1;
        }*/

        if (countdownToDestruction >= 0.9f)
        {
            Destroy(this.gameObject);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            if (collision.GetComponent<PowerLevels>().powerLevel > 1)
            {
                anim.SetBool("CanMelt", true);
                
                audioS.Play();
            }

        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            if (Input.GetKey(KeyCode.Alpha2))
            {
                if (collision.GetComponent<PowerLevels>().currentHealth <= 0)
                {
                    anim.speed = 0;
                    canAnimate = false;
                    //noiseMaker.SetActive(false);
                }
                else if (collision.GetComponent<PowerLevels>().currentHealth > 0)
                {
                    anim.speed = 1;
                    canAnimate = true;
                }
            }

            if (collision.GetComponent<PowerLevels>().powerLevel > 1)
            {
                countdownToDestruction += 1 * Time.deltaTime;
                anim.speed = 1;
            }
            else if (collision.GetComponent<PowerLevels>().powerLevel <= 1)
            {
                countdownToDestruction += 0;
                anim.speed = 0;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            if (collision.GetComponent<PowerLevels>().powerLevel > 1)
            {
                countdownToDestruction += 0;
                anim.speed = 0;
            }
        }
    }

    public void ResetAnimation()
    {
        countdownToDestruction = 0;
        anim.SetBool("CanMelt", false);
        
    }

    public void Destruction()
    {
        Destroy(this.gameObject);
    }

}
