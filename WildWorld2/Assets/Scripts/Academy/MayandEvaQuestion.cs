using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayandEvaQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3, question4, question5, question6;
    GameObject targetblock1, targetblock2;
    int questionNumber;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/03");
        question2 = Resources.Load<Sprite>("academy/04");

        rend.sprite = question1;

        targetblock1 = GameObject.Find("TargetBlock1");
        targetblock2 = GameObject.Find("TargetBlock2");
        targetblock1.SetActive(false);
        targetblock2.SetActive(false);

        questionNumber = 1;
    }

    void Update()
    {
        if (questionNumber == 2)
        {
            rend.sprite = question2;

            targetblock1.SetActive(true);
            targetblock2.SetActive(true);
        }
        if (questionNumber == 3)
        {
            rend.sprite = question3;
        }
        if (questionNumber == 4)
        {
            rend.sprite = question4;
        }
        if (questionNumber == 5)
        {
            rend.sprite = question5;
        }
        if (questionNumber == 6)
        {
            rend.sprite = question6;
        }
    }
    public void ChangeQuestion()
    {
        questionNumber++;
    }
}
