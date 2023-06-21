using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltableObject : MonoBehaviour
{
    public Animator anim;

    IEnumerator DestroyAfterAnimation()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            anim.SetBool("CanMelt", true);
        }
        StartCoroutine(DestroyAfterAnimation());
    }

}
