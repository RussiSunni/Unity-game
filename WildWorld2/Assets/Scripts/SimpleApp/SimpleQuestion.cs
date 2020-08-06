using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleQuestion : MonoBehaviour
{
    TheNaturalWorldQuestion Question = new TheNaturalWorldQuestion();

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
                   question018,
                   question019,
                   question020,
                   question021,
                   question022,
                   question023,
                   question024,
                   question025,
                   question026,
                   question027,
                   question028,
                   question029,
                   question030,
                   question031,
                   question032,
                   fairyIncorrect,
                   fairyNeutral,
                   fairyCorrect;
    int questionNumber, theNaturalWorld;
    Text answerText1, answerText2, answerText3, answerText4, results;

    public float timeRemaining = 0;

    bool timerReady, correctAnswer = false;

    void Start()
    {
        questionNumber = 1;

        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();
        results = GameObject.Find("Results").GetComponent<Text>();

        questionImage = GetComponent<Image>();

        // question001 = Resources.Load<Sprite>("SimpleApp/Questions/Cat");
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
        question018 = Resources.Load<Sprite>("SimpleApp/Questions/Frog");
        question019 = Resources.Load<Sprite>("SimpleApp/Questions/Tiger");
        question020 = Resources.Load<Sprite>("SimpleApp/Questions/Goat");
        question021 = Resources.Load<Sprite>("SimpleApp/Questions/Chicken");
        question022 = Resources.Load<Sprite>("SimpleApp/Questions/Elephant");

        question023 = Resources.Load<Sprite>("SimpleApp/Questions/Sister");
        question024 = Resources.Load<Sprite>("SimpleApp/Questions/Mother");
        question025 = Resources.Load<Sprite>("SimpleApp/Questions/Family");
        question026 = Resources.Load<Sprite>("SimpleApp/Questions/Reading");

        question027 = Resources.Load<Sprite>("SimpleApp/Questions/Mobile phone");
        question028 = Resources.Load<Sprite>("SimpleApp/Questions/Think");
        question029 = Resources.Load<Sprite>("SimpleApp/Questions/Sleep");
        question030 = Resources.Load<Sprite>("SimpleApp/Questions/Wake up");
        question031 = Resources.Load<Sprite>("SimpleApp/Questions/Deliver");

        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyIncorrect = Resources.Load<Sprite>("SimpleApp/FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("SimpleApp/FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("SimpleApp/FairyCorrect");


        questionImage.sprite = TheNaturalWorldQuestion.Question001.sprite;
        answerText1.text = TheNaturalWorldQuestion.Question001.answerOptions[0];
        answerText2.text = TheNaturalWorldQuestion.Question001.answerOptions[1];
        answerText3.text = TheNaturalWorldQuestion.Question001.answerOptions[2];
        answerText4.text = TheNaturalWorldQuestion.Question001.answerOptions[3];

        timerReady = false;
    }

    public void Answer1()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 4 || questionNumber == 8 || questionNumber == 12 || questionNumber == 15 || questionNumber == 19)
            correctAnswer = true;
        else
            correctAnswer = false;

        if (questionNumber == 4)
            PlayerPrefs.SetInt("Bear", 1);

        if (questionNumber == 8)
            PlayerPrefs.SetInt("Monkey", 1);

        if (questionNumber == 12)
            PlayerPrefs.SetInt("Alligator", 1);

        if (questionNumber == 15)
            PlayerPrefs.SetInt("Pig", 1);

        if (questionNumber == 19)
            PlayerPrefs.SetInt("Tiger", 1);
    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 3 || questionNumber == 5 || questionNumber == 9 || questionNumber == 13 || questionNumber == 21 || questionNumber == 22)
            correctAnswer = true;
        else
            correctAnswer = false;

        if (questionNumber == 3)
            PlayerPrefs.SetInt("Horse", 1);

        if (questionNumber == 5)
            PlayerPrefs.SetInt("Wolf", 1);

        if (questionNumber == 9)
            PlayerPrefs.SetInt("Squirrel", 1);

        if (questionNumber == 13)
            PlayerPrefs.SetInt("Rhinoceros", 1);

        if (questionNumber == 21)
            PlayerPrefs.SetInt("Chicken", 1);

        if (questionNumber == 22)
            PlayerPrefs.SetInt("Elephant", 1);
    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 1 || questionNumber == 7 || questionNumber == 11 || questionNumber == 16 || questionNumber == 17)
            correctAnswer = true;
        else
            correctAnswer = false;

        if (questionNumber == 1)
            PlayerPrefs.SetInt("Cat", 1);

        if (questionNumber == 7)
            PlayerPrefs.SetInt("Owl", 1);

        if (questionNumber == 11)
            PlayerPrefs.SetInt("Lion", 1);

        if (questionNumber == 16)
            PlayerPrefs.SetInt("Donkey", 1);

        if (questionNumber == 17)
            PlayerPrefs.SetInt("Rabbit", 1);

    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 2 || questionNumber == 6 || questionNumber == 10 || questionNumber == 14 || questionNumber == 18 || questionNumber == 20)
            correctAnswer = true;
        else
            correctAnswer = false;

        if (questionNumber == 2)
            PlayerPrefs.SetInt("Dog", 1);

        if (questionNumber == 6)
            PlayerPrefs.SetInt("Zebra", 1);

        if (questionNumber == 10)
            PlayerPrefs.SetInt("Giraffe", 1);

        if (questionNumber == 14)
            PlayerPrefs.SetInt("Duck", 1);

        if (questionNumber == 18)
            PlayerPrefs.SetInt("Frog", 1);

        if (questionNumber == 20)
            PlayerPrefs.SetInt("Goat", 1);
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
            if (questionNumber == 18)
            {
                questionImage.sprite = question018;
                answerText1.text = "fish";
                answerText2.text = "rhinoceros";
                answerText3.text = "lion";
                answerText4.text = "frog";
            }
            if (questionNumber == 19)
            {
                questionImage.sprite = question019;
                answerText1.text = "tiger";
                answerText2.text = "owl";
                answerText3.text = "cat";
                answerText4.text = "duck";
            }
            if (questionNumber == 20)
            {
                questionImage.sprite = question020;
                answerText1.text = "pig";
                answerText2.text = "donkey";
                answerText3.text = "sheep";
                answerText4.text = "goat";
            }
            if (questionNumber == 21)
            {
                questionImage.sprite = question021;
                answerText1.text = "sheep";
                answerText2.text = "chicken";
                answerText3.text = "donkey";
                answerText4.text = "pig";
            }
            if (questionNumber == 22)
            {
                questionImage.sprite = question022;
                answerText1.text = "mouse";
                answerText2.text = "elephant";
                answerText3.text = "rabbit";
                answerText4.text = "dog";
            }


            if (questionNumber == 23)
            {
                questionImage.sprite = question023;
                answerText1.text = "sister";
                answerText2.text = "rhinoceros";
                answerText3.text = "lion";
                answerText4.text = "frog";


            }
            if (questionNumber == 24)
            {
                results.text = "The Natural World: " + theNaturalWorld + " / 23";
                Debug.Log(results.text);
            }

            if (questionNumber == 25)
            {
                questionImage.sprite = question024;
                answerText1.text = "tiger";
                answerText2.text = "mother";
                answerText3.text = "cat";
                answerText4.text = "duck";
            }
            if (questionNumber == 25)
            {
                questionImage.sprite = question025;
                answerText1.text = "sister";
                answerText2.text = "family";
                answerText3.text = "sheep";
                answerText4.text = "goat";
            }
            if (questionNumber == 26)
            {
                questionImage.sprite = question026;
                answerText1.text = "sheep";
                answerText2.text = "chicken";
                answerText3.text = "donkey";
                answerText4.text = "reading";
            }

            if (questionNumber == 27)
            {
                questionImage.sprite = question027;
                answerText1.text = "sister";
                answerText2.text = "rhinoceros";
                answerText3.text = "lion";
                answerText4.text = "mobile phone";
            }
            if (questionNumber == 28)
            {
                questionImage.sprite = question028;
                answerText1.text = "tiger";
                answerText2.text = "think";
                answerText3.text = "cat";
                answerText4.text = "duck";
            }
            if (questionNumber == 29)
            {
                questionImage.sprite = question029;
                answerText1.text = "sister";
                answerText2.text = "family";
                answerText3.text = "sheep";
                answerText4.text = "sleep";
            }
            if (questionNumber == 30)
            {
                questionImage.sprite = question030;
                answerText1.text = "sheep";
                answerText2.text = "chicken";
                answerText3.text = "wake up";
                answerText4.text = "reading";
            }
            if (questionNumber == 31)
            {
                questionImage.sprite = question031;
                answerText1.text = "deliver";
                answerText2.text = "chicken";
                answerText3.text = "donkey";
                answerText4.text = "reading";
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

    void printPlayerPrefs()
    {
        theNaturalWorld = PlayerPrefs.GetInt("Cat") + PlayerPrefs.GetInt("Dog") + PlayerPrefs.GetInt("Horse") + PlayerPrefs.GetInt("Bear") + PlayerPrefs.GetInt("Wolf") + PlayerPrefs.GetInt("Zebra")
        + PlayerPrefs.GetInt("Owl") + PlayerPrefs.GetInt("Monkey") + PlayerPrefs.GetInt("Squirrel") + PlayerPrefs.GetInt("Giraffe") + PlayerPrefs.GetInt("Lion")
        + PlayerPrefs.GetInt("Alligator") + PlayerPrefs.GetInt("Rhinoceros") + PlayerPrefs.GetInt("Duck") + PlayerPrefs.GetInt("Pig") + PlayerPrefs.GetInt("Donkey")
        + PlayerPrefs.GetInt("Rabbit") + PlayerPrefs.GetInt("Frog") + PlayerPrefs.GetInt("Tiger") + PlayerPrefs.GetInt("Goat") + PlayerPrefs.GetInt("Chicken") + PlayerPrefs.GetInt("Elephant");
    }
}
