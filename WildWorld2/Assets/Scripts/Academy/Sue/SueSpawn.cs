using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueSpawn : MonoBehaviour
{
    private GameObject sueCard;
    void Start()
    {
        sueCard = GameObject.Find("SUE");
        sueCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playSUEWordSound();
        if (Progress.sue == false)
            sueCard.SetActive(true);
    }
}
