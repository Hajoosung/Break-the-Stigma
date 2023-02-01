using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ending : MonoBehaviour
{
    public GameObject tx1;
    public GameObject tx2;
    public GameObject text1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        text1.SetActive(false);

        yield return new WaitForSeconds(3f);
        tx1.SetActive(true);
        yield return new WaitForSeconds(7f);
        tx2.SetActive(true);

        yield return new WaitForSeconds(10f);

        SceneManager.LoadScene("opening");


    }
}
