using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{   
    public Animation anim;
    Boolean flag = false;
    //[SerializeField] GameObject obj;
    [SerializeField] GameObject text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            //Desctoy
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Dveri();
    }
    private void Dveri()
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim = GetComponent<Animation>();
            anim.Play("dver");
            anim.Play("dver1");
        }
        flag = true;
        print (flag);
    }
}
