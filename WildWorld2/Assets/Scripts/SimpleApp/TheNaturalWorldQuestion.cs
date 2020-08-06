using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheNaturalWorldQuestion : QuestionBase
{
    public static QuestionBase Question001 = new QuestionBase();
    public static QuestionBase Question002 = new QuestionBase();

    void Start()
    {
        Question001.number = 1;
        Question001.questionName = "cat";
        Question001.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat");
        Question001.answerOptions.Add("bear");
        Question001.answerOptions.Add("dog");
        Question001.answerOptions.Add("cat");
        Question001.answerOptions.Add("horse");

        Question002.number = 2;
        Question002.questionName = "dog";
        Question002.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog");
        Question002.answerOptions.Add("mouse");
        Question002.answerOptions.Add("cat");
        Question002.answerOptions.Add("duck");
        Question002.answerOptions.Add("dog");

    }
}
