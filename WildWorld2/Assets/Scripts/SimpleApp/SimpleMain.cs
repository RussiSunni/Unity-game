using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleMain : MonoBehaviour
{
    Image questionImage, fairyImage;
    private Sprite fairyIncorrect,
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

        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyIncorrect = Resources.Load<Sprite>("SimpleApp/FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("SimpleApp/FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("SimpleApp/FairyCorrect");

        questionImage.sprite = QuestionBank.questions[0].sprite;
        answerText1.text = QuestionBank.questions[0].answerOptions[0];
        answerText2.text = QuestionBank.questions[0].answerOptions[1];
        answerText3.text = QuestionBank.questions[0].answerOptions[2];
        answerText4.text = QuestionBank.questions[0].answerOptions[3];

        timerReady = false;
    }

    public void Answer1()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;
    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;
    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;
    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;
    }
    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            questionNumber++;

            questionImage.sprite = QuestionBank.questions[questionNumber - 1].sprite;
            answerText1.text = QuestionBank.questions[questionNumber - 1].answerOptions[0];
            answerText2.text = QuestionBank.questions[questionNumber - 1].answerOptions[1];
            answerText3.text = QuestionBank.questions[questionNumber - 1].answerOptions[2];
            answerText4.text = QuestionBank.questions[questionNumber - 1].answerOptions[3];
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
        if (QuestionBank.questions[questionNumber - 1].size == 2)
        {
            RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
            questionRT.sizeDelta = new Vector2(800, 712);
            questionRT.anchoredPosition = new Vector2(400, -356);

            RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
            fairyRT.sizeDelta = new Vector2(250.7f, 446.4f);
            fairyRT.anchoredPosition = new Vector2(274.7f, 223.2f);
        }
    }
}
