using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadSpawn : MonoBehaviour
{
    private GameObject readCard;
    void Start()
    {
        readCard = GameObject.Find("READ");
        readCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playSUEWordSound();
        if (Progress.read == false)
            readCard.SetActive(true);
    }
}

