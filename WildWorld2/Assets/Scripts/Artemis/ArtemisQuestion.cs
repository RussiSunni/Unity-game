using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArtemisQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;

    public static Sprite question1, question2, question3, question4, question5;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("cat");
        question2 = Resources.Load<Sprite>("dog");
        question3 = Resources.Load<Sprite>("owl");
        question4 = Resources.Load<Sprite>("bear");
        question5 = Resources.Load<Sprite>("wolf");
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.textNumber == 0)
        {
            rend.sprite = question1;
        }
        else if (TestExerciseNext.textNumber == 2)
        {
            rend.sprite = question2;
        }
        else if (TestExerciseNext.textNumber == 4)
        {
            rend.sprite = question3;
        }
        else if (TestExerciseNext.textNumber == 6)
        {
            rend.sprite = question4;
        }
        else if (TestExerciseNext.textNumber == 8)
        {
            rend.sprite = question5;
        }
    }
}
