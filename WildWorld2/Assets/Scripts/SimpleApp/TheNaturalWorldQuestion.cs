using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheNaturalWorldQuestion : SimpleQuestion
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
    public static SimpleQuestion question010 = new SimpleQuestion();
    public static SimpleQuestion question011 = new SimpleQuestion();
    public static SimpleQuestion question012 = new SimpleQuestion();
    public static SimpleQuestion question013 = new SimpleQuestion();
    public static SimpleQuestion question014 = new SimpleQuestion();
    public static SimpleQuestion question015 = new SimpleQuestion();
    public static SimpleQuestion question016 = new SimpleQuestion();
    public static SimpleQuestion question017 = new SimpleQuestion();
    public static SimpleQuestion question018 = new SimpleQuestion();
    public static SimpleQuestion question019 = new SimpleQuestion();
    public static SimpleQuestion question020 = new SimpleQuestion();
    public static SimpleQuestion question021 = new SimpleQuestion();
    public static SimpleQuestion question022 = new SimpleQuestion();

    void Start()
    {
        question001.number = 1;
        question001.questionName = "cat";
        question001.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat");
        question001.answerOptions.Add("bear");
        question001.answerOptions.Add("dog");
        question001.answerOptions.Add("cat");
        question001.answerOptions.Add("horse");

        questions.Add(question001);

        question002.number = 2;
        question002.questionName = "dog";
        question002.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog");
        question002.answerOptions.Add("mouse");
        question002.answerOptions.Add("cat");
        question002.answerOptions.Add("duck");
        question002.answerOptions.Add("dog");

        questions.Add(question002);

        question003.number = 3;
        question003.questionName = "horse";
        question003.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse");
        question003.answerOptions.Add("dog");
        question003.answerOptions.Add("horse");
        question003.answerOptions.Add("mouse");
        question003.answerOptions.Add("ant");

        questions.Add(question003);

        question004.number = 4;
        question004.questionName = "bear";
        question004.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Bear");
        question004.answerOptions.Add("bear");
        question004.answerOptions.Add("horse");
        question004.answerOptions.Add("mouse");
        question004.answerOptions.Add("ant");

        questions.Add(question004);

        question005.number = 5;
        question005.questionName = "wolf";
        question005.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf");
        question005.answerOptions.Add("dog");
        question005.answerOptions.Add("wolf");
        question005.answerOptions.Add("mouse");
        question005.answerOptions.Add("ant");

        questions.Add(question005);

        question006.number = 6;
        question006.questionName = "zebra";
        question006.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Zebra");
        question006.answerOptions.Add("dog");
        question006.answerOptions.Add("horse");
        question006.answerOptions.Add("mouse");
        question006.answerOptions.Add("zebra");

        questions.Add(question006);

        question007.number = 7;
        question007.questionName = "owl";
        question007.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl");
        question007.answerOptions.Add("dog");
        question007.answerOptions.Add("horse");
        question007.answerOptions.Add("owl");
        question007.answerOptions.Add("ant");

        questions.Add(question007);

        question008.number = 8;
        question008.questionName = "monkey";
        question008.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Monkey");
        question008.answerOptions.Add("monkey");
        question008.answerOptions.Add("horse");
        question008.answerOptions.Add("mouse");
        question008.answerOptions.Add("ant");

        questions.Add(question008);

        question009.number = 9;
        question009.questionName = "squirrel";
        question009.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel");
        question009.answerOptions.Add("dog");
        question009.answerOptions.Add("squirrel");
        question009.answerOptions.Add("mouse");
        question009.answerOptions.Add("ant");

        questions.Add(question009);

        question010.number = 10;
        question010.questionName = "giraffe";
        question010.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe");
        question010.answerOptions.Add("dog");
        question010.answerOptions.Add("horse");
        question010.answerOptions.Add("mouse");
        question010.answerOptions.Add("giraffe");

        questions.Add(question010);

        question011.number = 11;
        question011.questionName = "lion";
        question011.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Lion");
        question011.answerOptions.Add("dog");
        question011.answerOptions.Add("horse");
        question011.answerOptions.Add("lion");
        question011.answerOptions.Add("ant");

        questions.Add(question011);

        question012.number = 12;
        question012.questionName = "alligator";
        question012.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Alligator");
        question012.answerOptions.Add("alligator");
        question012.answerOptions.Add("horse");
        question012.answerOptions.Add("mouse");
        question012.answerOptions.Add("ant");

        questions.Add(question012);

        question013.number = 13;
        question013.questionName = "rhinoceros";
        question013.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros");
        question013.answerOptions.Add("dog");
        question013.answerOptions.Add("rhinoceros");
        question013.answerOptions.Add("mouse");
        question013.answerOptions.Add("ant");

        questions.Add(question013);

        question014.number = 14;
        question014.questionName = "duck";
        question014.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Duck");
        question014.answerOptions.Add("rhinoceros");
        question014.answerOptions.Add("horse");
        question014.answerOptions.Add("mouse");
        question014.answerOptions.Add("duck");

        questions.Add(question014);

        question015.number = 15;
        question015.questionName = "pig";
        question015.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Pig");
        question015.answerOptions.Add("dog");
        question015.answerOptions.Add("horse");
        question015.answerOptions.Add("mouse");
        question015.answerOptions.Add("pig");

        questions.Add(question015);

        question016.number = 16;
        question016.questionName = "donkey";
        question016.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Donkey");
        question016.answerOptions.Add("dog");
        question016.answerOptions.Add("horse");
        question016.answerOptions.Add("donkey");
        question016.answerOptions.Add("ant");

        questions.Add(question016);

        question017.number = 17;
        question017.questionName = "rabbit";
        question017.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit");
        question017.answerOptions.Add("dog");
        question017.answerOptions.Add("horse");
        question017.answerOptions.Add("rabbit");
        question017.answerOptions.Add("ant");

        questions.Add(question017);

        question018.number = 18;
        question018.questionName = "frog";
        question018.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Frog");
        question018.answerOptions.Add("dog");
        question018.answerOptions.Add("horse");
        question018.answerOptions.Add("mouse");
        question018.answerOptions.Add("frog");

        questions.Add(question018);

        question019.number = 19;
        question019.questionName = "tiger";
        question019.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Tiger");
        question019.answerOptions.Add("tiger");
        question019.answerOptions.Add("horse");
        question019.answerOptions.Add("mouse");
        question019.answerOptions.Add("ant");

        questions.Add(question019);

        question020.number = 20;
        question020.questionName = "goat";
        question020.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Goat");
        question020.answerOptions.Add("dog");
        question020.answerOptions.Add("horse");
        question020.answerOptions.Add("mouse");
        question020.answerOptions.Add("goat");

        questions.Add(question020);

        question021.number = 21;
        question021.questionName = "chicken";
        question021.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Chicken");
        question021.answerOptions.Add("dog");
        question021.answerOptions.Add("chicken");
        question021.answerOptions.Add("mouse");
        question021.answerOptions.Add("ant");

        questions.Add(question021);

        question022.number = 22;
        question022.questionName = "elephant";
        question022.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Elephant");
        question022.answerOptions.Add("dog");
        question022.answerOptions.Add("elephant");
        question022.answerOptions.Add("mouse");
        question022.answerOptions.Add("ant");

        questions.Add(question022);
    }
}
