using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge1trigger : MonoBehaviour
{
    // Start is called before the first frame update
 public GamePlayUI GUI;
    void OnTriggerEnter(Collider other)
    {
        GUI.dialog3.gameObject.SetActive(true);
        Invoke("DisableText", 5f);
    }

      void DisableText()
    { 
        GUI.dialog3.gameObject.SetActive(false);
    }  

     void OnTriggerExit(Collider other)
    {
         GUI.dialog3.gameObject.SetActive(false);
    }
}
