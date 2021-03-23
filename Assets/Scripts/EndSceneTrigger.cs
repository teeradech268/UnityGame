using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter(Collider other)
    {
        Initiate.Fade("EndScene",Color.black,1f);
    }
}
