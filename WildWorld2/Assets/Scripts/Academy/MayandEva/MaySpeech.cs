using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaySpeech : MonoBehaviour
{
    GameObject maySpeech;

    void Start()
    {
        maySpeech = GameObject.Find("MaySpeech");
        maySpeech.SetActive(false);
    }
    private void OnMouseDown()
    {
        maySpeech.SetActive(true);
    }
}
