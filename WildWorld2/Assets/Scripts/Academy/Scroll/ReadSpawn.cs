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
        if (Progress.read == false)
        {
            SoundManagerScript.playREADWordSound();
            readCard.SetActive(true);
        }
    }
}

