using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //count Item
    //  อย่าลืมหา object Inventory  มาใส่ 
    public Inventory inventory;

    //GameManager 
    // สร้าง object GameObject ใส่ 
    GameManager GM;

    //จัดการ highlight + เก็บไอเทม
    private string ItemTag = "Item";
    private Transform tempObject;
    private int countcheck = 0;

    public AudioClip sound;

    

    //GUI
    public GamePlayUI GUI;
    

    // Start is called before the first frame update
    void Start()
    {
        // หา object ที่ชื่อ "GameManager"
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        //set gui
        GUI.SetItemRequirement(inventory.ItemRequirement);
        
        Invoke("DisableText", 5f);


        
    }

    // Update is called once per frame
    void Update()
    {
        HighlightItem();

    }

    void DisableText()
    { 
        GUI.dialog1.gameObject.SetActive(false);
        GUI.dialog2.gameObject.SetActive(false);
        GUI.dialog3.gameObject.SetActive(false);
        GUI.dialog4.gameObject.SetActive(false);
        GUI.dialog5.gameObject.SetActive(false);
        GUI.dialog6.gameObject.SetActive(false);
        GUI.dialog7.gameObject.SetActive(false);
        GUI.dialog8.gameObject.SetActive(false);
    }    

    void HighlightItem()
    {
        if (tempObject != null)
        {
            tempObject.GetComponent<Item>().SetOutline(false);
            tempObject = null;
        }

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5f))
        {
            Transform selection = hit.transform;
            if (selection.CompareTag(ItemTag))
            {
                Item _item = selection.GetComponent<Item>();
                _item.SetOutline(true);
                tempObject = selection;
                if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("Fire1"))
                {
                    inventory.AddItem();
                    AudioSource.PlayClipAtPoint(sound,transform.position);
                    _item.DestroySelf();
                    
                    // สั่ง GUI
                    GUI.SetItemAmount(inventory.ItemAmount);
                    if (inventory.ItemAmount > 0)
                    {
                        GUI._itemAmount.gameObject.SetActive(true);
                        GUI._itemRequirement.gameObject.SetActive(true);
                    }
                }
            }

        }
    }

    //อันนี้เดินเข้าไปเปลี่ยนฉาก
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            if (inventory.UseItem())
            {
                //Debug.Log("True load");
                Initiate.Fade("Past1",Color.black,1f);
            }
            else
            {
                //สั่ง GUI เตือน
                //Debug.Log("True no");
                GUI._request.gameObject.SetActive(true);
            }
        }
        //else
        //{
        //    Debug.Log("false");
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        GUI._request.gameObject.SetActive(false);
    }

    //อันนี้มีกำแพงกั้นระหว่าง scene
    //คำเตือน ถ้าหากใน scene มีหลายด่านนอกจาก scene MeandTeddy_S1 อีกจะเขียนแบบนี้ไม่ได้แล้ว
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            if (inventory.UseItem())
            {
                //Debug.Log("True load");
                GUI.dialog4.gameObject.SetActive(true);
                Invoke("DisableText", 5f);
                Destroy(collision.gameObject);

                // ถ้าหากปรับให้ทุกด่านเก็บไอเทมเท่ากัน uncomment/ลบ บรรทัดข้างล่างได้
                inventory.ItemAmount = 0;
                inventory.ItemRequirement = 3;
                //สั่ง GUI เตือน
                GUI.SetItemAmount(inventory.ItemAmount);
                GUI.SetItemRequirement(inventory.ItemRequirement);
            }
            else
            {
                //สั่ง GUI เตือน
                //Debug.Log("True no");
                GUI._request.gameObject.SetActive(true);
            }
        }
        //else
        //{
        //    Debug.Log("false");
        //}
    }

    private void OnCollisionExit(Collision collision)
    {
        GUI._request.gameObject.SetActive(false);
    }
}

