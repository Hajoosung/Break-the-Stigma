using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Rigidbody gr1;
    public Rigidbody gr2;
    public Rigidbody gr3;
    public Rigidbody gr4;
    public Rigidbody gr5;
    public Rigidbody gr6;
    public Rigidbody gr7;
    public Rigidbody gr8;

    public Rigidbody gr9;
    public Rigidbody gr10;

    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {

        yield return new WaitForSeconds(1f);

        gr1.useGravity = true;
        gr8.useGravity = true;

        yield return new WaitForSeconds(0.5f);

        gr2.useGravity = true;
        gr7.useGravity = true;
        yield return new WaitForSeconds(0.5f);

        gr3.useGravity = true;
        gr4.useGravity = true;
        gr5.useGravity = true;
        gr6.useGravity = true;

        yield return new WaitForSeconds(0.5f);

        gr9.useGravity = true;
        gr10.useGravity = true;

    }
}
