using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalFoodQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalFood001 = new SimpleQuestion();

    void Start()
    {
        animalFood001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "carrots",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat"),
            answerOptions = new List<string>()
        {
            "mouse",
            "horse",
            "cat",
            "rabbit"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };
    }
    public static void LoadQuestionList()
    {
        // if (GameControl.animalFood001known == false)
        questions.Add(animalFood001);

        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}