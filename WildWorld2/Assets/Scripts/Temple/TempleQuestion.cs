using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3, question4, question5, question6, question7, question8, question9, question10, question11, question12;
    int questionNumber = 1;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("temple/colours01");
        question2 = Resources.Load<Sprite>("temple/colours02");
        question3 = Resources.Load<Sprite>("temple/colours03");
        question4 = Resources.Load<Sprite>("temple/colours04");
        question5 = Resources.Load<Sprite>("temple/colours05");
        question6 = Resources.Load<Sprite>("temple/colours06");
        question7 = Resources.Load<Sprite>("temple/colours07");
        question8 = Resources.Load<Sprite>("temple/colours08");
        question9 = Resources.Load<Sprite>("temple/colours09");
        question10 = Resources.Load<Sprite>("temple/colours10");
        question11 = Resources.Load<Sprite>("temple/colours11");
        question12 = Resources.Load<Sprite>("temple/colours12");
        rend.sprite = question1;
    }

    public void ChangeQuestion()
    {
        questionNumber++;

        if (questionNumber == 2)
        {
            rend.sprite = question2;
        }
        else if (questionNumber == 3)
        {
            rend.sprite = question3;
        }
        else if (questionNumber == 4)
        {
            rend.sprite = question4;
        }
        else if (questionNumber == 5)
        {
            rend.sprite = question5;
        }
        else if (questionNumber == 6)
        {
            rend.sprite = question6;
        }
        else if (questionNumber == 7)
        {
            rend.sprite = question7;
        }
        else if (questionNumber == 8)
        {
            rend.sprite = question8;
        }
        else if (questionNumber == 9)
        {
            rend.sprite = question9;
        }
        else if (questionNumber == 10)
        {
            rend.sprite = question10;
        }
        else if (questionNumber == 11)
        {
            rend.sprite = question11;
        }
        else if (questionNumber == 12)
        {
            rend.sprite = question12;
        }

    }
}
