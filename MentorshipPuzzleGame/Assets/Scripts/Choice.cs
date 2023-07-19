using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public bool punch = false;
    public bool kickCrotch = false;
    public bool kickButt = false;

    public GameObject punchOutcome;
    public GameObject crotchKickOutcome;
    public GameObject buttKickOutcome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToChoiceMade()
    {
        if (punch)
        {
            punchOutcome.SetActive(true);
        }
        else if (kickCrotch)
        {
            crotchKickOutcome.SetActive(true);
        }
        else if (kickButt)    
        {
            buttKickOutcome.SetActive(true);
        }
    }

    public void Choice1Made()
    {
        punch = true;
    }

    public void Choice2Made()
    {
        kickCrotch = true;
    }

    public void Choice3Made()
    {
        kickButt = true;
    }
}
