using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherQuestions : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion question001 = new SimpleQuestion();
    public static SimpleQuestion question002 = new SimpleQuestion();
    public static SimpleQuestion question003 = new SimpleQuestion();
    public static SimpleQuestion question004 = new SimpleQuestion();
    public static SimpleQuestion question005 = new SimpleQuestion();
    public static SimpleQuestion question006 = new SimpleQuestion();
    public static SimpleQuestion question007 = new SimpleQuestion();
    public static SimpleQuestion question008 = new SimpleQuestion();
    public static SimpleQuestion question009 = new SimpleQuestion();

    void Start()
    {
        question001.number = 1;
        question001.questionName = "sister";
        question001.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sister");
        question001.answerOptions.Add("sister");
        question001.answerOptions.Add("dog");
        question001.answerOptions.Add("cat");
        question001.answerOptions.Add("horse");

        questions.Add(question001);

        question002.number = 2;
        question002.questionName = "mother";
        question002.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mother");
        question002.answerOptions.Add("sister");
        question002.answerOptions.Add("mother");
        question002.answerOptions.Add("cat");
        question002.answerOptions.Add("horse");

        questions.Add(question002);

        question003.number = 3;
        question003.questionName = "family";
        question003.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Family");
        question003.answerOptions.Add("sister");
        question003.answerOptions.Add("mother");
        question003.answerOptions.Add("family");
        question003.answerOptions.Add("horse");

        questions.Add(question003);

        question004.number = 4;
        question004.questionName = "reading";
        question004.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Reading");
        question004.answerOptions.Add("sister");
        question004.answerOptions.Add("mother");
        question004.answerOptions.Add("family");
        question004.answerOptions.Add("reading");

        questions.Add(question004);

        question005.number = 5;
        question005.questionName = "mobile phone";
        question005.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mobile phone");
        question005.answerOptions.Add("mobile phone");
        question005.answerOptions.Add("mother");
        question005.answerOptions.Add("family");
        question005.answerOptions.Add("reading");

        questions.Add(question005);

        question006.number = 6;
        question006.questionName = "think";
        question006.sprite = Resources.Load<Sprite>("SimpleApp/Questions/think");
        question005.answerOptions.Add("think");
        question005.answerOptions.Add("mother");
        question005.answerOptions.Add("family");
        question005.answerOptions.Add("reading");

        questions.Add(question006);

        question007.number = 7;
        question007.questionName = "sleep";
        question007.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sleep");
        question007.answerOptions.Add("think");
        question007.answerOptions.Add("sleep");
        question007.answerOptions.Add("family");
        question007.answerOptions.Add("reading");

        questions.Add(question007);

        question008.number = 8;
        question008.questionName = "wake up";
        question008.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wake up");
        question008.answerOptions.Add("think");
        question008.answerOptions.Add("sleep");
        question008.answerOptions.Add("wake up");
        question008.answerOptions.Add("reading");

        questions.Add(question008);

        question009.number = 9;
        question009.questionName = "deliver";
        question009.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Deliver");
        question009.answerOptions.Add("deliver");
        question009.answerOptions.Add("sleep");
        question009.answerOptions.Add("wake up");
        question009.answerOptions.Add("reading");

        questions.Add(question009);
    }
}