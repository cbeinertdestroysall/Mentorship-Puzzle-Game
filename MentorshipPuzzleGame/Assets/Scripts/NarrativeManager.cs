using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeManager : MonoBehaviour
{
    public GameObject aKey;
    

    public float timeToShow;

    public bool canShow;

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
        if (canShow == true)
        {
            aKey.gameObject.SetActive(true);
            canShow = false;
            //StartCoroutine(DisableAKey());
        }
    }

    
}
