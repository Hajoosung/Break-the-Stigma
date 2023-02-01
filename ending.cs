using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class opening : MonoBehaviour
{
    public GameObject fadeout;

    public GameObject tx1;
    public GameObject tx2;

    public AudioSource click;

    // Start is called before the first frame update
    public void onclick()
    {
        StartCoroutine(_typing());

    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        click.Play();
        fadeout.SetActive(true);

        yield return new WaitForSeconds(1f);

        tx1.SetActive(true);
        tx2.SetActive(true);

        yield return new WaitForSeconds(4f);
       

        SceneManager.LoadScene("please1-opening");


    }
}
