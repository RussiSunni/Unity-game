using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorCard;

    void Start()
    {
        doorCard = GameObject.Find("Door Card");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playDOORWordSound();
        AcademyScript.DoorActive();
    }

}