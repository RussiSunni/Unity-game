using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaySpawn : MonoBehaviour
{
    private GameObject mayCard;
    void Start()
    {
        mayCard = GameObject.Find("MAY");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playMAYWordSound();
        AcademyScript.MayActive();
    }
}
