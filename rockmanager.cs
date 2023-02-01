using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rockmanager : MonoBehaviour
{
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;

    public GameObject text1;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(10f);
        rock1.SetActive(true);
        text1.SetActive(true);

        yield return new WaitForSeconds(13f);
        rock2.SetActive(true);
        yield return new WaitForSeconds(13f);
        rock3.SetActive(true);
        yield return new WaitForSeconds(12f);
        rock4.SetActive(true);



    }
}
