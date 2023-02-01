using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Keyfind : MonoBehaviour
{
    public GameObject text;
    public GameObject tx;
    public GameObject txlock;
    public GameObject keys;

    public GameObject text4;
    public GameObject text5;


    public GameObject key;

    public GameObject fakedoor;
    public GameObject door;

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

    public void locktrue()
    {
        txlock.SetActive(true);
        keys.SetActive(true);

        text4.SetActive(false);
        text5.SetActive(true);

    }
    public void lockfalse()
    {
        txlock.SetActive(false);

    }
    IEnumerator _typing()
    {

        tx.SetActive(true);

        yield return new WaitForSeconds(3f);

        tx.SetActive(false);

        fakedoor.SetActive(false);
        door.SetActive(true);

    }
}

