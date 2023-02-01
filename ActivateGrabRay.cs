using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ActivateGrabRay : MonoBehaviour
{
    public GameObject RightGrabRay;

    public XRDirectInteractor rightDirectGrab;

    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        RightGrabRay.SetActive(rightDirectGrab.interactablesSelected.Count == 0);
    }
}
