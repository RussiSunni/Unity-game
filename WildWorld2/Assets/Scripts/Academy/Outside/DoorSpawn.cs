using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawn : MonoBehaviour
{
    public GameObject doorCard;
    void Start()
    {
        doorCard = GameObject.Find("DOOR");
        doorCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playDOORWordSound();
        if (Progress.door == false)
            doorCard.SetActive(true);
    }
}