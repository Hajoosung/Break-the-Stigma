using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class lightdestroy : MonoBehaviour

    
{
   
    public GameObject man;

    public GameObject lights;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void first()
    {
        StartCoroutine(_typing());


    }

    public void here2()
    {
        lights.SetActive(true);

        man.SetActive(false);
    }
   
    IEnumerator _typing()
    {

        yield return new WaitForSeconds(2f);

        lights.SetActive(false);

        man.SetActive(true);

        yield return new WaitForSeconds(0.7f);

        here2();

    }

    public void exit()
    {

        SceneManager.LoadScene("please2");

    }
}

