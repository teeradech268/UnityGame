using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXplaying : MonoBehaviour
{
    public AudioSource Pick_Up;


    public void PlayPickUp()
    {
        Pick_Up.Play();
    }
}
