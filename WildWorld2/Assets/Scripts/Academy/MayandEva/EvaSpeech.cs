using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaSpeech : MonoBehaviour
{
    GameObject evaSpeech;

    void Start()
    {
        evaSpeech = GameObject.Find("EvaSpeech");
        evaSpeech.SetActive(false);
    }
    private void OnMouseDown()
    {
        evaSpeech.SetActive(true);
    }
}
