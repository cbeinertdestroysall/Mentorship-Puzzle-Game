using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeManager : MonoBehaviour
{
    public GameObject aKey;
    public GameObject narrative2;

    public float timeToShow;

    public bool canShow1;

    public bool canShow2;

    IEnumerator DisableAKey()
    {
        yield return new WaitForSeconds(timeToShow);
        aKey.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AKey()
    {
        if (canShow1 == true)
        {
            aKey.gameObject.SetActive(true);
            canShow1 = false;
            //StartCoroutine(DisableAKey());
        }
    }

    public void ShowNarrative2()
    {
        if (canShow2 == true)
        {
            narrative2.gameObject.SetActive(true);
            canShow2 = false;
        }
    }

    
}
