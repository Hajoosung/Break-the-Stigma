using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class txmanager2 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    public GameObject text5;

    public GameObject text6;

    public float LimitTime;
    public TextMeshProUGUI text_Timer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "제한시간 : " + Mathf.Round(LimitTime);

      
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(4f);

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
        yield return new WaitForSeconds(4f);

        text4.SetActive(false);

        text5.SetActive(true);

       
        yield return new WaitForSeconds(200f);

        SceneManager.LoadScene("please3");


    }
    // Update is called once per frame

}
