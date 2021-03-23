using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlayUI : MonoBehaviour
{
    public Text _itemAmount;
    public Text _itemRequirement;
    public Text _request;

    public Text dialog1;
    public Text dialog2;
    public Text dialog3;
    public Text dialog4;
    public Text dialog5;
    public Text dialog6;
    public Text dialog7;
    public Text dialog8;

    public Button quit;


    // Start is called before the first frame update
    void Start()
    {
        _itemAmount.gameObject.SetActive(false);
        _itemRequirement.gameObject.SetActive(false);
        _request.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        dialog1.gameObject.SetActive(true);
        dialog2.gameObject.SetActive(false);
        dialog3.gameObject.SetActive(false);
        dialog4.gameObject.SetActive(false);
        dialog5.gameObject.SetActive(false);
        dialog6.gameObject.SetActive(false);
        dialog7.gameObject.SetActive(false);
        dialog8.gameObject.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetItemAmount(int value)
    {
        string text = value.ToString();
        _itemAmount.text = text;
    }

    public void SetItemRequirement(int value)
    {
        string text = value.ToString();
        _itemRequirement.text = "/"+text;
    }


}
