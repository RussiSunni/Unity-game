using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleQuestion : MonoBehaviour
{
    TheNaturalWorldQuestion Question = new TheNaturalWorldQuestion();

    Image questionImage, fairyImage;
    private Sprite
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



        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyIncorrect = Resources.Load<Sprite>("SimpleApp/FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("SimpleApp/FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("SimpleApp/FairyCorrect");

        questionImage.sprite = TheNaturalWorldQuestion.questions[0].sprite;
        answerText1.text = TheNaturalWorldQuestion.questions[0].answerOptions[0];
        answerText2.text = TheNaturalWorldQuestion.questions[0].answerOptions[1];
        answerText3.text = TheNaturalWorldQuestion.questions[0].answerOptions[2];
        answerText4.text = TheNaturalWorldQuestion.questions[0].answerOptions[3];

        timerReady = false;
    }

    public void Answer1()
    {
        timeRemaining = 1;

        timerReady = true;

        if (TheNaturalWorldQuestion.questions[questionNumber - 1].questionName == answerText1.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(TheNaturalWorldQuestion.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;

    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (TheNaturalWorldQuestion.questions[questionNumber - 1].questionName == answerText2.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(TheNaturalWorldQuestion.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;

    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (TheNaturalWorldQuestion.questions[questionNumber - 1].questionName == answerText3.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(TheNaturalWorldQuestion.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;

    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (TheNaturalWorldQuestion.questions[questionNumber - 1].questionName == answerText4.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(TheNaturalWorldQuestion.questions[questionNumber - 1].questionName, 1);
        }
        else
            correctAnswer = false;
    }

    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            questionNumber++;

            if (questionNumber < 24)
            {
                questionImage.sprite = TheNaturalWorldQuestion.questions[questionNumber - 1].sprite;
                answerText1.text = TheNaturalWorldQuestion.questions[questionNumber - 1].answerOptions[0];
                answerText2.text = TheNaturalWorldQuestion.questions[questionNumber - 1].answerOptions[1];
                answerText3.text = TheNaturalWorldQuestion.questions[questionNumber - 1].answerOptions[2];
                answerText4.text = TheNaturalWorldQuestion.questions[questionNumber - 1].answerOptions[3];
            }
            if (questionNumber == 24)
            {
                questionImage.sprite = null;
                answerText1.text = "";
                answerText2.text = "";
                answerText3.text = "";
                answerText4.text = "";

                printPlayerPrefs();
                results.text = "The Natural World: " + theNaturalWorld + " / 23";
            }
            if (questionNumber > 24)
            {
                results.text = null;

                questionImage.sprite = OtherQuestions.questions[questionNumber - 25].sprite;
                answerText1.text = OtherQuestions.questions[questionNumber - 25].answerOptions[0];
                answerText2.text = OtherQuestions.questions[questionNumber - 25].answerOptions[1];
                answerText3.text = OtherQuestions.questions[questionNumber - 25].answerOptions[2];
                answerText4.text = OtherQuestions.questions[questionNumber - 25].answerOptions[3];
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
        theNaturalWorld = PlayerPrefs.GetInt("cat") + PlayerPrefs.GetInt("dog") + PlayerPrefs.GetInt("horse") + PlayerPrefs.GetInt("bear") + PlayerPrefs.GetInt("wolf") + PlayerPrefs.GetInt("zebra")
        + PlayerPrefs.GetInt("owl") + PlayerPrefs.GetInt("monkey") + PlayerPrefs.GetInt("squirrel") + PlayerPrefs.GetInt("giraffe") + PlayerPrefs.GetInt("lion")
        + PlayerPrefs.GetInt("alligator") + PlayerPrefs.GetInt("rhinoceros") + PlayerPrefs.GetInt("duck") + PlayerPrefs.GetInt("pig") + PlayerPrefs.GetInt("donkey")
        + PlayerPrefs.GetInt("rabbit") + PlayerPrefs.GetInt("frog") + PlayerPrefs.GetInt("tiger") + PlayerPrefs.GetInt("goat") + PlayerPrefs.GetInt("chicken") + PlayerPrefs.GetInt("Elephant");
    }
}
