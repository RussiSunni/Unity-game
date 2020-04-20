using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArtemisIntroScript : MonoBehaviour
{
    public static int numClicks;

    GameObject exerciseArea;


    void Start()
    {
        numClicks = 0;
        exerciseArea = GameObject.Find("ExerciseArea");
    }


    public void ChangeScene()
    {
        numClicks++;

        if (numClicks == 1)
        {
            exerciseArea.SetActive(false);
            ArtemisIntroSpriteScript.secondClick = true;
        }

        if (numClicks == 2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}



