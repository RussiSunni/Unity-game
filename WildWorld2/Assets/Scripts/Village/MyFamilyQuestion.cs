using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFamilyQuestion : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite question1, question2, question3, question4, question5;


    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("village/my_family-01");
        question2 = Resources.Load<Sprite>("village/my_family-02");
        question3 = Resources.Load<Sprite>("village/my_family-03");
        question4 = Resources.Load<Sprite>("village/my_family-04");
        question5 = Resources.Load<Sprite>("village/my_family-05");
        rend.sprite = question1;
    }

    void Update()
    {
        if (MyFamilyNext.questionNumber == 2)
        {
            rend.sprite = question2;
        }

        if (MyFamilyNext.questionNumber == 3)
        {
            rend.sprite = question3;
        }

        if (MyFamilyNext.questionNumber == 4)
        {
            rend.sprite = question4;
        }

        if (MyFamilyNext.questionNumber == 5)
        {
            rend.sprite = question5;
        }
    }
}
