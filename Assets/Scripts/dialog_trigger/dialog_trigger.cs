using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog_trigger : MonoBehaviour
{
    // Start is called before the first frame update
     public GamePlayUI GUI;
    void OnTriggerEnter(Collider other)
    {
        GUI.dialog2.gameObject.SetActive(true);
        Invoke("DisableText", 5f);
    }

      void DisableText()
    { 
        GUI.dialog2.gameObject.SetActive(false);
    }  

    void OnTriggerExit(Collider other)
    {
         GUI.dialog2.gameObject.SetActive(false);
    }
}
