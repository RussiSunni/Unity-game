using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestExerciseNext : MonoBehaviour
{

    public static bool catFlag = false;
    public static bool dogFlag = false;

    public GameObject spawnee1;
    public GameObject spawnee2;

    public GameObject exerciseArea;

    public static int numberPresses = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void ChangeQuestion()
    {
        Debug.Log(catFlag);

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
    }
}
