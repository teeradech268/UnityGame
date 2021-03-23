using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    //Rotation Speed ความเร็วในการหมุน
    public float x_rotate_speed = 0f;
    public float y_rotate_speed = 1f;
    public float z_rotate_speed = 0f;

    Outline outline;


    // Start is called before the first frame update
    void Start()
    {
        try
        {
            outline = gameObject.GetComponent<Outline>();
            outline.OutlineColor = Color.yellow;
            outline.OutlineWidth = 10f;
            SetOutline(false);
        }
        catch
        {
            
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        RotateSelf();
    }

    //ทำลายตัวเองเรียกใช้โดยคนอื่น
    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    //หมุนตัวเอง
    void RotateSelf()
    {
        transform.Rotate(x_rotate_speed, y_rotate_speed, z_rotate_speed);
    }

    //ปรับ outline
    public void SetOutline(bool value)
    {
        try
        {
            outline.enabled = value;
        }
        catch { }
    }

    
}
