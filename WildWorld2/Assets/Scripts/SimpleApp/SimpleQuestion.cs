using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleQuestion : MonoBehaviour
{
    Image questionImage, fairyImage;
    private Sprite question001,
                   question002,
                   question003,
                   question004,
                   question005,
                   question006,
                   question007,
                   question008,
                   question009,
                   question010,
                   question011,
                   question012,
                   question013,
                   question014,
                   question015,
                   question016,
                   question017,
                   fairyIncorrect,
                   fairyNeutral,
                   fairyCorrect;
    int questionNumber;
    Text answerText1, answerText2, answerText3, answerText4;

    public float timeRemaining = 0;

    bool timerReady, correctAnswer = false;

    void Start()
    {
        questionNumber = 1;

        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();

        questionImage = GetComponent<Image>();

        question001 = Resources.Load<Sprite>("SimpleApp/Questions/Cat");
        question002 = Resources.Load<Sprite>("SimpleApp/Questions/Dog");
        question003 = Resources.Load<Sprite>("SimpleApp/Questions/Horse");
        question004 = Resources.Load<Sprite>("SimpleApp/Questions/Bear");
        question005 = Resources.Load<Sprite>("SimpleApp/Questions/Wolf");
        question006 = Resources.Load<Sprite>("SimpleApp/Questions/Zebra");
        question007 = Resources.Load<Sprite>("SimpleApp/Questions/Owl");
        question008 = Resources.Load<Sprite>("SimpleApp/Questions/Monkey");
        question009 = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel");
        question010 = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe");
        question011 = Resources.Load<Sprite>("SimpleApp/Questions/Lion");
        question012 = Resources.Load<Sprite>("SimpleApp/Questions/Alligator");
        question013 = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros");
        question014 = Resources.Load<Sprite>("SimpleApp/Questions/Duck");
        question015 = Resources.Load<Sprite>("SimpleApp/Questions/Pig");
        question016 = Resources.Load<Sprite>("SimpleApp/Questions/Donkey");
        question017 = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit");

        questionImage.sprite = question001;

        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyIncorrect = Resources.Load<Sprite>("SimpleApp/FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("SimpleApp/FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("SimpleApp/FairyCorrect");

        answerText1.text = "bear";
        answerText2.text = "dog";
        answerText3.text = "cat";
        answerText4.text = "horse";

        timerReady = false;
    }

    public void Answer1()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 4 || questionNumber == 8 || questionNumber == 12 || questionNumber == 15)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 3 || questionNumber == 5 || questionNumber == 9 || questionNumber == 13)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 1 || questionNumber == 7 || questionNumber == 11 || questionNumber == 16 || questionNumber == 17)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 2 || questionNumber == 6 || questionNumber == 10 || questionNumber == 14)
            correctAnswer = true;
        else
            correctAnswer = false;
    }

    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            questionNumber++;
            if (questionNumber == 2)
            {
                questionImage.sprite = question002;
                answerText1.text = "mouse";
                answerText2.text = "cat";
                answerText3.text = "duck";
                answerText4.text = "dog";
            }
            if (questionNumber == 3)
            {
                questionImage.sprite = question003;
                answerText1.text = "dog";
                answerText2.text = "horse";
                answerText3.text = "mouse";
                answerText4.text = "ant";
            }
            if (questionNumber == 4)
            {
                questionImage.sprite = question004;
                answerText1.text = "bear";
                answerText2.text = "cat";
                answerText3.text = "dog";
                answerText4.text = "owl";
            }
            if (questionNumber == 5)
            {
                questionImage.sprite = question005;
                answerText1.text = "mouse";
                answerText2.text = "wolf";
                answerText3.text = "owl";
                answerText4.text = "cat";
            }
            if (questionNumber == 6)
            {
                questionImage.sprite = question006;
                answerText1.text = "wolf";
                answerText2.text = "dog";
                answerText3.text = "horse";
                answerText4.text = "zebra";
            }
            if (questionNumber == 7)
            {
                questionImage.sprite = question007;
                answerText1.text = "duck";
                answerText2.text = "cat";
                answerText3.text = "owl";
                answerText4.text = "horse";
            }
            if (questionNumber == 8)
            {
                questionImage.sprite = question008;
                answerText1.text = "monkey";
                answerText2.text = "zebra";
                answerText3.text = "wolf";
                answerText4.text = "owl";
            }
            if (questionNumber == 9)
            {
                questionImage.sprite = question009;
                answerText1.text = "wolf";
                answerText2.text = "squirrel";
                answerText3.text = "owl";
                answerText4.text = "monkey";
            }
            if (questionNumber == 10)
            {
                questionImage.sprite = question010;
                answerText1.text = "horse";
                answerText2.text = "monkey";
                answerText3.text = "zebra";
                answerText4.text = "giraffe";
            }
            if (questionNumber == 11)
            {
                questionImage.sprite = question011;
                answerText1.text = "cat";
                answerText2.text = "wolf";
                answerText3.text = "lion";
                answerText4.text = "monkey";
            }
            if (questionNumber == 12)
            {
                questionImage.sprite = question012;
                answerText1.text = "alligator";
                answerText2.text = "owl";
                answerText3.text = "giraffe";
                answerText4.text = "lion";
            }
            if (questionNumber == 13)
            {
                questionImage.sprite = question013;
                answerText1.text = "giraffe";
                answerText2.text = "rhinoceros";
                answerText3.text = "lion";
                answerText4.text = "alligator";
            }
            if (questionNumber == 14)
            {
                questionImage.sprite = question014;
                answerText1.text = "chicken";
                answerText2.text = "owl";
                answerText3.text = "cat";
                answerText4.text = "duck";
            }
            if (questionNumber == 15)
            {
                questionImage.sprite = question015;
                answerText1.text = "pig";
                answerText2.text = "donkey";
                answerText3.text = "sheep";
                answerText4.text = "cow";
            }
            if (questionNumber == 16)
            {
                questionImage.sprite = question016;
                answerText1.text = "sheep";
                answerText2.text = "zebra";
                answerText3.text = "donkey";
                answerText4.text = "pig";
            }
            if (questionNumber == 17)
            {
                questionImage.sprite = question017;
                answerText1.text = "mouse";
                answerText2.text = "cat";
                answerText3.text = "rabbit";
                answerText4.text = "dog";
            }
        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (correctAnswer)
                fairyImage.sprite = fairyCorrect;
            else
                fairyImage.sprite = fairyIncorrect;
        }
        else
        {
            fairyImage.sprite = fairyNeutral;
            ChangeQuestion();
            timerReady = false;
        }
    }
}
