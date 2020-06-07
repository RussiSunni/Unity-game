using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secretary : MonoBehaviour
{
    public GameObject helloCard;
    void Start()
    {
        helloCard = GameObject.Find("HELLO");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playDOORWordSound();
        AcademyScript.HelloActive();
    }
}
