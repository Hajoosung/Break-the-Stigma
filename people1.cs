using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class people1 : MonoBehaviour
{
    public GameObject image;
    public GameObject people2;
    public GameObject people2fake;



    private AudioSource keyaudioeffect;


    // Start is called before the first frame update
    void Start()
    {
        keyaudioeffect = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    public void effect1()
    {
        keyaudioeffect.Play();


        image.SetActive(false);
        people2.SetActive(true);
        people2fake.SetActive(false);


    }

  

   
}

