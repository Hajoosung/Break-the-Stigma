using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeyDestroy : MonoBehaviour
{
    public GameObject text;
    public GameObject tx;
    public GameObject key;

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

        yield return new WaitForSeconds(3f);

        tx.SetActive(false);

    }
}

