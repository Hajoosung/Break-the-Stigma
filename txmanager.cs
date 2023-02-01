using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class txmanager : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public GameObject text4;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }
    IEnumerator _typing()
    {
        text1.SetActive(true);

        yield return new WaitForSeconds(4f);
        text1.SetActive(false);
        text2.SetActive(true);

        yield return new WaitForSeconds(4f);

        text2.SetActive(false);
        text3.SetActive(true);
        yield return new WaitForSeconds(4f);
        text3.SetActive(false);
        text4.SetActive(true);

        yield return new WaitForSeconds(186f);

        SceneManager.LoadScene("please2");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
