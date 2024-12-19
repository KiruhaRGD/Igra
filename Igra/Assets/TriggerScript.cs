using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(obj, transform.position, Quaternion.identity);
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
        
    }
}
