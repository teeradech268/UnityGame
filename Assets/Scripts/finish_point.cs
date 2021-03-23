using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_point : MonoBehaviour
{
    public Inventory inventory;
    Collider finish_door;
    public GamePlayUI GUI;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision){
    Debug.Log("hit detected");
    if(collision.gameObject.tag == "Player")
        {
            if (inventory.UseItem())
            { 
                finish_door = GetComponent<Collider>();
                finish_door.isTrigger = true;
            }
             else
            {
                //สั่ง GUI เตือน
                //Debug.Log("True no");
                GUI._request.gameObject.SetActive(true);
            }
        }

    }
}
