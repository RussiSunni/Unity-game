using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademyScript : MonoBehaviour
{
    public static GameObject doorCard;
    void Start()
    {
        doorCard = GameObject.Find("Door Card");
        doorCard.SetActive(false);
    }

    public static void DoorActive()
    {
        doorCard.SetActive(true);
    }
}
