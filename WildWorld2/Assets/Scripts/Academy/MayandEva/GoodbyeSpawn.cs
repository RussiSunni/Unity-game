using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GoodbyeSpawn : MonoBehaviour
{
    public static GameObject goodbyeCard;
    void Start()
    {
        goodbyeCard = GameObject.Find("GOODBYE");
        goodbyeCard.SetActive(false);
    }

    public static void MakeActive()
    {
        if (Progress.goodbye == false)
        {
            SoundManagerScript.playDOORWordSound();
            goodbyeCard.SetActive(true);
        }
    }
}