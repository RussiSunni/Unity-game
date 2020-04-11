using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestExerciseNext : MonoBehaviour
{

    public static bool catFlag, dogFlag, owlFlag, bearFlag, wolfFlag = false;

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
        SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;


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

        if (O.locked && W.locked && L.locked && !F.locked)
        {
            owlFlag = true;
            O.locked = false;
            O.reset = true;
            W.locked = false;
            W.reset = true;
            L.locked = false;
            L.reset = true;
        }

        if (B.locked && E.locked && A.locked && R.locked)
        {
            bearFlag = true;
            B.locked = false;
            B.reset = true;
            E.locked = false;
            E.reset = true;
            A.locked = false;
            A.reset = true;
            R.locked = false;
            R.reset = true;
        }

        if (W.locked && O.locked && L.locked && F.locked)
        {
            wolfFlag = true;
            W.locked = false;
            W.reset = true;
            O.locked = false;
            O.reset = true;
            L.locked = false;
            L.reset = true;
            F.locked = false;
            F.reset = true;
        }
    }
}
