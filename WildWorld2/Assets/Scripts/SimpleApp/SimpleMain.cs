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

    int score;

    public Text fairyTalk;

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

        fairyTalk = GameObject.Find("FairyTalk").GetComponent<Text>();



    }

    public void Answer1()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
            QuestionBank.questions[questionNumber - 1].known = true;

        }
        else
            correctAnswer = false;

        QuestionBank.questions[questionNumber - 1].answered = true;
    }
    public void Answer2()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
            QuestionBank.questions[questionNumber - 1].known = true;

        }
        else
            correctAnswer = false;

        QuestionBank.questions[questionNumber - 1].answered = true;
    }
    public void Answer3()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
            QuestionBank.questions[questionNumber - 1].known = true;

        }
        else
            correctAnswer = false;

        QuestionBank.questions[questionNumber - 1].answered = true;
    }
    public void Answer4()
    {
        timeRemaining = 1;

        timerReady = true;

        if (QuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
        {
            correctAnswer = true;
            PlayerPrefs.SetInt(QuestionBank.questions[questionNumber - 1].questionName, 1);
            QuestionBank.questions[questionNumber - 1].known = true;

        }
        else
            correctAnswer = false;

        QuestionBank.questions[questionNumber - 1].answered = true;
    }
    void ChangeQuestion()
    {
        if (timerReady == true)
        {
            if (questionNumber < QuestionBank.questions.Count)
                questionNumber++;
            else
                questionNumber = 1;

            questionImage.sprite = QuestionBank.questions[questionNumber - 1].sprite;
            answerText1.text = QuestionBank.questions[questionNumber - 1].answerOptions[0];
            answerText2.text = QuestionBank.questions[questionNumber - 1].answerOptions[1];
            answerText3.text = QuestionBank.questions[questionNumber - 1].answerOptions[2];
            answerText4.text = QuestionBank.questions[questionNumber - 1].answerOptions[3];
        }

        // add Fairy feedback based on how well they do with animals
        score = 0;

        score = PlayerPrefs.GetInt("cat") + PlayerPrefs.GetInt("dog") + PlayerPrefs.GetInt("horse") + PlayerPrefs.GetInt("bear") + PlayerPrefs.GetInt("wolf") + PlayerPrefs.GetInt("zebra")
              + PlayerPrefs.GetInt("owl") + PlayerPrefs.GetInt("monkey") + PlayerPrefs.GetInt("squirrel") + PlayerPrefs.GetInt("giraffe") + PlayerPrefs.GetInt("lion")
              + PlayerPrefs.GetInt("alligator") + PlayerPrefs.GetInt("rhinoceros") + PlayerPrefs.GetInt("duck") + PlayerPrefs.GetInt("pig") + PlayerPrefs.GetInt("donkey")
              + PlayerPrefs.GetInt("rabbit") + PlayerPrefs.GetInt("frog") + PlayerPrefs.GetInt("tiger") + PlayerPrefs.GetInt("goat") + PlayerPrefs.GetInt("chicken") + PlayerPrefs.GetInt("Elephant");

        if (score == 20)
        {
            fairyTalk.text = "Wow, you really know this content";
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
        else if (QuestionBank.questions[questionNumber - 1].size == 1)
        {
            RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
            questionRT.sizeDelta = new Vector2(400, 712);
            questionRT.anchoredPosition = new Vector2(200, -356);

            RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
            fairyRT.sizeDelta = new Vector2(400f, 712f);
            fairyRT.anchoredPosition = new Vector2(200f, 356.1402f);
        }
    }
}
