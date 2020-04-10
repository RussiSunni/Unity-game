using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestExerciseNext : MonoBehaviour
{

    public static bool catFlag = false;
    public static bool dogFlag = false;
    public static bool owlFlag = false;

    public GameObject exerciseArea, CAT, DOG;

    GameObject fairy, fairyAnimation;

    public static int numberPresses = 0;

    void Start()
    {

        fairy = GameObject.Find("Fairy");
        fairyAnimation = GameObject.Find("Fairy animation");
    }

    void Update()
    {

    }

    public void ChangeQuestion()
    {
        fairyAnimation.SetActive(false);
        fairy.SetActive(true);


        if (C.locked && A.locked && T.locked)
        {
            catFlag = true;
            C.locked = false;
            C.reset = true;
            A.locked = false;
            A.reset = true;
            T.locked = false;
            T.reset = true;
        }

        if (D.locked && O.locked && G.locked)
        {
            dogFlag = true;
            D.locked = false;
            D.reset = true;
            O.locked = false;
            O.reset = true;
            G.locked = false;
            G.reset = true;
        }

        if (O.locked && W.locked && L.locked)
        {
            owlFlag = true;
            O.locked = false;
            O.reset = true;
            W.locked = false;
            W.reset = true;
            L.locked = false;
            L.reset = true;
        }
    }
}
