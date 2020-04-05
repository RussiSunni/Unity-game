using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExerciseNextScene : MonoBehaviour
{
    private string sceneName;

    public static bool catFlag = false;
    public static bool dogFlag = false;

    public GameObject spawnee1;
    public GameObject spawnee2;

    public GameObject exerciseArea;

    void Start()
    {

    }


    void Update()
    {
        if (catFlag)
        {
            GameObject childObject1 = Instantiate(spawnee1) as GameObject;
            exerciseArea = GameObject.Find("ExerciseArea");
            childObject1.transform.SetParent(exerciseArea.transform, false);
            catFlag = false;
        }
        if (dogFlag)
        {
            GameObject childObject2 = Instantiate(spawnee2) as GameObject;
            exerciseArea = GameObject.Find("ExerciseArea");
            childObject2.transform.SetParent(exerciseArea.transform, false);
            dogFlag = false;
        }
    }

    public void ChangeScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "CatExercise")
        {
            if (LetterCTouch.locked && LetterATouch.locked && LetterTTouch.locked || LetterAMouse.locked && LetterCMouse.locked && LetterTMouse.locked)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                catFlag = true;
            }
        }

        if (sceneName == "DogExercise")
        {
            if (LetterDTouch.locked && LetterOTouch.locked && LetterGTouch.locked || LetterDMouse.locked && LetterOMouse.locked && LetterGMouse.locked)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                dogFlag = true;

            }
        }

        if (sceneName == "OwlExercise")
        {
            if (LetterOTouch.locked && LetterWTouch.locked && LetterLTouch.locked || LetterOMouse.locked && LetterWMouse.locked && LetterLMouse.locked)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        if (sceneName == "BearExercise")
        {
            if (LetterBTouch.locked && LetterETouch.locked && LetterATouch.locked && LetterRTouch.locked || LetterBMouse.locked && LetterEMouse.locked && LetterAMouse.locked && LetterRMouse.locked)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }
}
