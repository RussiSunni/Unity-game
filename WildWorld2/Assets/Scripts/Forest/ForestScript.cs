using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestScript : MonoBehaviour
{
    public static GameObject bearCard;

    void Start()
    {
        bearCard = GameObject.Find("Bear Card");
        bearCard.SetActive(false);
    }

    public static void BearActive()
    {
        bearCard.SetActive(true);
    }
}
