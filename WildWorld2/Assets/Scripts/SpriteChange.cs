using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteChange : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite fairy01, fairy02, fairy03;
    private string sceneName;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        fairy01 = Resources.Load<Sprite>("fairy01");
        fairy02 = Resources.Load<Sprite>("fairy02");
        fairy03 = Resources.Load<Sprite>("fairy03");
        rend.sprite = fairy01;
    }

    // Update is called once per frame
    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "CatExercise")
        {
            if (LetterATouch.pressed || LetterCTouch.pressed || LetterTTouch.pressed || LetterAMouse.pressed || LetterCMouse.pressed || LetterTMouse.pressed)
            {
                rend.sprite = fairy02;
            }
            else
            {
                rend.sprite = fairy01;
            }
            if (LetterCTouch.locked && LetterATouch.locked && LetterTTouch.locked || LetterAMouse.locked && LetterCMouse.locked && LetterTMouse.locked)
            {
                rend.sprite = fairy03;
            }
        }

        if (sceneName == "DogExercise")
        {
            if (LetterDTouch.pressed || LetterOTouch.pressed || LetterGTouch.pressed || LetterDMouse.pressed || LetterOMouse.pressed || LetterGMouse.pressed)
            {
                rend.sprite = fairy02;
            }
            else
            {
                rend.sprite = fairy01;
            }
            if (LetterDTouch.locked && LetterOTouch.locked && LetterGTouch.locked || LetterDMouse.locked && LetterOMouse.locked && LetterGMouse.locked)
            {
                rend.sprite = fairy03;
            }
        }

        if (sceneName == "OwlExercise")
        {
            if (LetterOTouch.pressed || LetterWTouch.pressed || LetterLTouch.pressed || LetterOMouse.pressed || LetterWMouse.pressed || LetterLMouse.pressed)
            {
                rend.sprite = fairy02;
            }
            else
            {
                rend.sprite = fairy01;
            }
            if (LetterOTouch.locked && LetterWTouch.locked && LetterLTouch.locked || LetterOMouse.locked && LetterWMouse.locked && LetterLMouse.locked)
            {
                rend.sprite = fairy03;
            }
        }

        if (sceneName == "BearExercise")
        {
            if (LetterBTouch.pressed || LetterETouch.pressed || LetterATouch.pressed || LetterRTouch.pressed || LetterBMouse.pressed || LetterEMouse.pressed || LetterAMouse.pressed || LetterRMouse.pressed)
            {
                rend.sprite = fairy02;
            }
            else
            {
                rend.sprite = fairy01;
            }
            if (LetterBTouch.locked && LetterETouch.locked && LetterATouch.locked && LetterRTouch.locked || LetterBMouse.locked && LetterEMouse.locked && LetterAMouse.locked  && LetterRMouse.locked)
            {
                rend.sprite = fairy03;
            }
        }
    }
}
