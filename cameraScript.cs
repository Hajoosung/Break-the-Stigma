using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public GameObject xrcamera;
    public GameObject keymanager;


    void Start()
    {
        StartCoroutine(_typing());
        
    }

    IEnumerator _typing()
    {

        yield return new WaitForSeconds(8.9f);

        xrcamera.SetActive(true);
        keymanager.GetComponent<txmanager>().enabled = true;

        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
