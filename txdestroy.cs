using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txdestroy : MonoBehaviour
{
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(6f);
        light.SetActive(false);
    }
}
