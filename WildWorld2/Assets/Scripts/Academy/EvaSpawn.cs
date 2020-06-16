using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaSpawn : MonoBehaviour
{
    private GameObject evaCard;
    void Start()
    {
        evaCard = GameObject.Find("EVA");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playEVAWordSound();
        AcademyScript.EvaActive();
    }
}
