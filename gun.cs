using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gun : MonoBehaviour
{
    public GameObject tx;
    public GameObject tx1;
    public GameObject tx2;

    public GameObject text;

    private AudioSource keyaudioeffect;
   

    // Start is called before the first frame update
    void Start()
    {
        keyaudioeffect = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    public void here()
    {
        keyaudioeffect.Play();

        gameObject.GetComponent<rockmanager>().enabled = true;

        StartCoroutine(_typing());

    }

   
    IEnumerator _typing()
    {

        tx.SetActive(true);

        yield return new WaitForSeconds(2f);

        tx.SetActive(false);

        yield return new WaitForSeconds(1f);

        tx1.SetActive(true);
        yield return new WaitForSeconds(2f);

        Destroy(tx1);

        yield return new WaitForSeconds(1f);

        tx2.SetActive(true);

        yield return new WaitForSeconds(2f);

        Destroy(tx2);

    }
}

