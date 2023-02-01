using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeyDestroy3 : MonoBehaviour
{
    public GameObject text;
    public GameObject tx;
    public GameObject key;
    public GameObject scary;
    public GameObject lights;
    public GameObject music;



    void Start()
    {

    }

    // Update is called once per frame
    public void here()
    {
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

        scary.SetActive(true);
        lights.SetActive(false);
        music.SetActive(true);

        yield return new WaitForSeconds(8f);

        scary.SetActive(false);
        lights.SetActive(true);
        music.SetActive(false);

    }
}

