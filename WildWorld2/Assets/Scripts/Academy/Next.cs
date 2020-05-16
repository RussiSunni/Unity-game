using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public static int questionNumber;
    public void Start()
    {
        questionNumber = 1;
    }

    public void ChangeQuestion()
    {
        questionNumber++;
    }
}
