using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruintrigger : MonoBehaviour
{
 public GamePlayUI GUI;
    void OnTriggerEnter(Collider other)
    {
        GUI.dialog7.gameObject.SetActive(true);
        Invoke("DisableText", 5f);
    }

      void DisableText()
    { 
        GUI.dialog7.gameObject.SetActive(false);
    }  

     void OnTriggerExit(Collider other)
    {
         GUI.dialog7.gameObject.SetActive(false);
    }
}
