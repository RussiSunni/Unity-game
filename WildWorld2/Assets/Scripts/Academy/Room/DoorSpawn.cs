using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawn : MonoBehaviour
{
    public GameObject doorCard;

    void Start()
    {
        doorCard = GameObject.Find("DOOR");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playDOORWordSound();
        AcademyScript.DoorActive();
    }

}