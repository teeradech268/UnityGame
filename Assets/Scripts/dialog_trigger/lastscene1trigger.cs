using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastscene1trigger : MonoBehaviour
{
 public GamePlayUI GUI;
    void OnTriggerEnter(Collider other)
    {
        GUI.dialog8.gameObject.SetActive(true);
        Invoke("DisableText", 5f);
    }

      void DisableText()
    { 
        GUI.dialog8.gameObject.SetActive(false);
    }  

    void OnTriggerExit(Collider other)
    {
         GUI.dialog8.gameObject.SetActive(false);
    }
}
