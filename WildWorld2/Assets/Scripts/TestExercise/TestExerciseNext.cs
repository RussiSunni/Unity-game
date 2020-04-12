using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestExerciseNext : MonoBehaviour
{

    public static bool catFlag, dogFlag, owlFlag, bearFlag, wolfFlag = false;

    GameObject fairy, fairyAnimation;

    public static int textNumber = 0;

    void Start()
    {
        fairy = GameObject.Find("Fairy");
        fairyAnimation = GameObject.Find("Fairy animation");
    }

    public void ChangeQuestion()
    {
        if (TestExerciseNext.textNumber == 0 || TestExerciseNext.textNumber == 2 || TestExerciseNext.textNumber == 4)
        {
            TestExerciseNext.textNumber++;
        }

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
            SpellBook.CATAttained = true;
            ExerciseArea.artemis = true;
            TestExerciseNext.textNumber = 2;
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
            SpellBook.DOGAttained = true;
            ExerciseArea.artemis = true;
            TestExerciseNext.textNumber = 4;
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
            ExerciseArea.artemis = true;
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
            ExerciseArea.artemis = true;
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
            ExerciseArea.artemis = true;
        }

        ExerciseArea.SwitchCamera();
    }
}
