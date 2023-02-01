using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeyDestroy5 : MonoBehaviour
{
    public GameObject text;
    public GameObject tx;
    public GameObject key;

    public GameObject notkey;

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

        text.SetActive(false);

        key.SetActive(false);
        StartCoroutine(_typing());

    }

    public void here2()
    {
        text.SetActive(true);
    }
    public void here3()
    {
        text.SetActive(false);
    }
    IEnumerator _typing()
    {

        tx.SetActive(true);
        notkey.SetActive(true);
        yield return new WaitForSeconds(2f);

        notkey.SetActive(false);

        yield return new WaitForSeconds(4f);

        tx.SetActive(false);

    }
}

