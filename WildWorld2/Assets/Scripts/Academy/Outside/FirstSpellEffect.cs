using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSpellEffect : MonoBehaviour
{

    public static GameObject gameobject;

    public static float timeLeft = 0f;

    void Start()
    {
        gameobject = this.gameObject;
        this.gameObject.SetActive(false);
    }
    public static void Display()
    {
        gameobject.gameObject.SetActive(true);
        timeLeft = 5.0f;
    }
    public static void Hide()
    {
        gameobject.gameObject.SetActive(false);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Hide();
        }
    }
}