using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;



public class trigger : XRSimpleInteractable
{
    public string openAnimation;
    public string closingAnimation;
    private Animator animator;
    private bool enable = false;
    private AudioSource doorclose;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        doorclose = GetComponent<AudioSource>();
    }
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        enable = !enable;
        if(enable == true)
        {
            animator.Play(openAnimation);
            doorclose.Play();
        }
        else
        {
            animator.Play(closingAnimation);
            doorclose.Play();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
