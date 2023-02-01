using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bookfind : MonoBehaviour
{
    public GameObject text;
    public GameObject ui;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void here()
    {
        ui.SetActive(true);


    }

    public void here2()
    {
        text.SetActive(true);
    }
    public void here3()
    {
        text.SetActive(false);
    }
    public void here4()
    {
        ui.SetActive(false);
    }
}

