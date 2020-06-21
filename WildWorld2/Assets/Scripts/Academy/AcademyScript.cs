﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcademyScript : MonoBehaviour
{
    public static GameObject doorCard, helloCard, evaCard, mayCard;
    public Transform player;
    void Start()
    {
        doorCard = GameObject.Find("DOOR");
        //doorCard.SetActive(false);

        helloCard = GameObject.Find("HELLO");
        helloCard.SetActive(false);

        evaCard = GameObject.Find("EVA");
        evaCard.SetActive(false);

        mayCard = GameObject.Find("MAY");
        mayCard.SetActive(false);


        if (Progress.previousScene == "Hub")
        {
            player.position = new Vector2(-4.859997f, -3.39125f);
        }
        else if (Progress.previousScene == "SecretaryExercise")
        {
            player.position = new Vector2(-5.559997f, 3.847678f);
        }
        else if (Progress.previousScene == "FairyExercise")
        {
            player.position = new Vector2(5.459997f, -2.79125f);
        }
        else if (Progress.previousScene == "PlayerRoom")
        {
            player.position = new Vector2(5.459997f, 2.808749f);
        }
        else if (Progress.previousScene == "MagazineExercise")
        {
            player.position = new Vector2(0.6999999f, 18.64768f);
        }
        else if (Progress.previousScene == "GreetingExercise")
        {
            player.position = new Vector2(-11.98001f, 12.60875f);
        }
        else if (Progress.previousScene == "HelloExercise")
        {
            player.position = new Vector2(-16.48003f, 16.20876f);
        }
        else if (Progress.previousScene == "IntroducingExercise")
        {
            player.position = new Vector2(0.6199963f, 10.40874f);
        }
        else if (Progress.previousScene == "AcademySpellbook")
        {
            player.position = new Vector2(9f, 9f);
        }
    }


    public static void DoorActive()
    {
        if (Progress.door == false)
            doorCard.SetActive(false);
    }
    public static void HelloActive()
    {
        if (Progress.hello == false)
            helloCard.SetActive(true);
    }

    public static void EvaActive()
    {
        if (Progress.eva == false)
            evaCard.SetActive(true);
    }
    public static void MayActive()
    {
        if (Progress.may == false)
            mayCard.SetActive(true);
    }

    public void LoadDictionary()
    {
        //previousPlayerPosition = player;
        SceneManager.LoadScene("AcademyDictionary");
    }
}
