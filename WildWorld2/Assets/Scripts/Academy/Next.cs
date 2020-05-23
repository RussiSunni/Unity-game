using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public static int questionNumber;

    GameObject may, eva;

    public void Start()
    {
        questionNumber = 1;
        may = GameObject.Find("MAY 1");
        eva = GameObject.Find("EVA");
    }

    public void ChangeQuestion()
    {
        questionNumber++;
        may.transform.position = new Vector2(8, 0.3f);
        May.initialPosition = new Vector2(8, 0.3f);
        eva.transform.position = new Vector2(8, 1.2f);
        Eva.initialPosition = new Vector2(8, 1.2f);
    }
}
