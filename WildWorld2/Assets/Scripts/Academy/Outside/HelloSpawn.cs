using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSpawn : MonoBehaviour
{
    private GameObject helloCard;
    void Start()
    {
        helloCard = GameObject.Find("HELLO");
        helloCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        if (!helloCard.activeSelf & !Progress.hello)
            SoundManagerScript.playHELLOWordSound();
        if (Progress.hello == false)
            helloCard.SetActive(true);
    }
}
