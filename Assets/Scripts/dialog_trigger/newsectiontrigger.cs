using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsectiontrigger : MonoBehaviour
{
 public GamePlayUI GUI;
    void OnTriggerEnter(Collider other)
    {
        GUI.dialog5.gameObject.SetActive(true);
        Invoke("DisableText", 5f);
    }

      void DisableText()
    { 
        GUI.dialog5.gameObject.SetActive(false);
    }  

     void OnTriggerExit(Collider other)
    {
         GUI.dialog5.gameObject.SetActive(false);
    }
}
