using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleQuestion : MonoBehaviour
{
    Image questionImage, fairyImage;
    private Sprite question001, question002, question003, question004, fairyIncorrect, fairyNeutral, fairyCorrect;
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

        question001 = Resources.Load<Sprite>("SimpleApp/Cat");
        question002 = Resources.Load<Sprite>("SimpleApp/Dog");
        question003 = Resources.Load<Sprite>("SimpleApp/Horse");
        question004 = Resources.Load<Sprite>("SimpleApp/Bear");
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

        if (questionNumber == 4)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 3)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 1)
            correctAnswer = true;
        else
            correctAnswer = false;
    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (questionNumber == 2)
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
