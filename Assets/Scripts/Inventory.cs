using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //ตั้งค่า default ได้
    public int ItemRequirement = 5;
    public int ItemAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // เพิ่ม Item
    public void CheckItem(int value)
    {
        if ((ItemAmount + value) >= 0)
        {
            ItemAmount += value;

        }
    }

    // ตรวจว่ามีของตามกำหนดหรือไม่
    public bool UseItem()
    {
        bool isMetRequirement = false;
        if (ItemAmount >= ItemRequirement)
        {
            isMetRequirement = true;
        }
        return isMetRequirement;
    }

    // เพิ่ม Item ในกระเป๋า 1 ชิ้น
    public void AddItem()
    {
        CheckItem(1);
    }

    public void ResetKeyItem()
    {
        ItemAmount = 0;
    }

}
