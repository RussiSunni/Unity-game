using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSpawn : MonoBehaviour
{
    public static GameObject scroll;
    void Start()
    {
        scroll = GameObject.Find("Scroll");
        scroll.SetActive(false);
    }

    public static void DisplayScroll()
    {
        scroll.SetActive(true);
    }

    public static void HideScroll()
    {
        scroll.SetActive(false);
    }
}

