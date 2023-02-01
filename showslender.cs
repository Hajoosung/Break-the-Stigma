using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showslender : MonoBehaviour
{
    public GameObject scary;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(5f);
        scary.SetActive(true);



    }
}
