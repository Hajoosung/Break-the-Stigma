using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slender : MonoBehaviour
{
    public GameObject fadeout;
    public GameObject ending;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "45ACP Bullet_Head(Clone)")
        {
            fadeout.SetActive(true);
            ending.SetActive(true);


            gameObject.SetActive(false);

        }
    }

   
}
