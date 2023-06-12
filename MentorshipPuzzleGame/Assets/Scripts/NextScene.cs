using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public GameObject transitionColor;
    
    IEnumerator NextSceneTransition()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Level 2");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransitionAnimation()
    {
        transitionColor.gameObject.SetActive(true);
        transitionColor.GetComponent<Animator>().SetBool("IsReady", true);
        StartCoroutine(NextSceneTransition());
    }
}
