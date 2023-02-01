using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class people2 : MonoBehaviour
{
    public GameObject image;
    public GameObject people3;
    public GameObject people3fake;


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
        people3.SetActive(true);
        people3fake.SetActive(false);
    }
}

