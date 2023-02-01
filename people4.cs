using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class people4 : MonoBehaviour
{
    public GameObject image;
    public GameObject people5;
    public GameObject floor;

    public GameObject text1;
    public GameObject text2;

    private AudioSource keyaudioeffect;


    // Start is called before the first frame update
    void Start()
    {
        keyaudioeffect = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    public void effectfake()
    {
        keyaudioeffect.Play();


        

        
    }

    public void effect()

    {
        keyaudioeffect.Play();

        image.SetActive(false);
        people5.SetActive(true);
        floor.SetActive(false);
        StartCoroutine(_typing());

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(1f);

        text1.SetActive(true);

        yield return new WaitForSeconds(4f);
        text1.SetActive(false);

        text2.SetActive(true);
        yield return new WaitForSeconds(4f);
        text2.SetActive(false);

    }
}

