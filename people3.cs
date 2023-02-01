using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class people3 : MonoBehaviour
{
    public GameObject image;
    public GameObject people4;
    public GameObject people4fake;


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
        people4.SetActive(true);
        people4fake.SetActive(false);
    }
}

