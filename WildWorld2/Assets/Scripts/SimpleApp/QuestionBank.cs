using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();

    SimpleQuestion animal001 = new SimpleQuestion()
    {
        number = 1,
        questionName = "cat",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat"),
        answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        }
    };

    void Start()
    {
        SimpleQuestion animal002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog")
        };
        animal002.answerOptions.Add("mouse");
        animal002.answerOptions.Add("cat");
        animal002.answerOptions.Add("duck");
        animal002.answerOptions.Add("dog");

        SimpleQuestion animal003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse")
        };
        animal003.answerOptions.Add("dog");
        animal003.answerOptions.Add("horse");
        animal003.answerOptions.Add("mouse");
        animal003.answerOptions.Add("ant");

        SimpleQuestion animal004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Bear")
        };
        animal004.answerOptions.Add("bear");
        animal004.answerOptions.Add("horse");
        animal004.answerOptions.Add("mouse");
        animal004.answerOptions.Add("ant");

        SimpleQuestion animal005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf")
        };
        animal005.answerOptions.Add("dog");
        animal005.answerOptions.Add("wolf");
        animal005.answerOptions.Add("mouse");
        animal005.answerOptions.Add("ant");

        SimpleQuestion animal006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Zebra")
        };
        animal006.answerOptions.Add("dog");
        animal006.answerOptions.Add("horse");
        animal006.answerOptions.Add("mouse");
        animal006.answerOptions.Add("zebra");

        SimpleQuestion animal007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl")
        };
        animal007.answerOptions.Add("dog");
        animal007.answerOptions.Add("horse");
        animal007.answerOptions.Add("owl");
        animal007.answerOptions.Add("zebra");


        // question007.number = 7;
        // question007.questionName = "owl";
        // question007.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl");
        // question007.answerOptions.Add("dog");
        // question007.answerOptions.Add("horse");
        // question007.answerOptions.Add("owl");
        // question007.answerOptions.Add("ant");

        // questions.Add(question007);

        // question008.number = 8;
        // question008.questionName = "monkey";
        // question008.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Monkey");
        // question008.answerOptions.Add("monkey");
        // question008.answerOptions.Add("horse");
        // question008.answerOptions.Add("mouse");
        // question008.answerOptions.Add("ant");

        // questions.Add(question008);

        // question009.number = 9;
        // question009.questionName = "squirrel";
        // question009.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel");
        // question009.answerOptions.Add("dog");
        // question009.answerOptions.Add("squirrel");
        // question009.answerOptions.Add("mouse");
        // question009.answerOptions.Add("ant");

        // questions.Add(question009);

        // question010.number = 10;
        // question010.questionName = "giraffe";
        // question010.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe");
        // question010.answerOptions.Add("dog");
        // question010.answerOptions.Add("horse");
        // question010.answerOptions.Add("mouse");
        // question010.answerOptions.Add("giraffe");

        // questions.Add(question010);

        // question011.number = 11;
        // question011.questionName = "lion";
        // question011.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Lion");
        // question011.answerOptions.Add("dog");
        // question011.answerOptions.Add("horse");
        // question011.answerOptions.Add("lion");
        // question011.answerOptions.Add("ant");

        // questions.Add(question011);

        // question012.number = 12;
        // question012.questionName = "alligator";
        // question012.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Alligator");
        // question012.answerOptions.Add("alligator");
        // question012.answerOptions.Add("horse");
        // question012.answerOptions.Add("mouse");
        // question012.answerOptions.Add("ant");

        // questions.Add(question012);

        // question013.number = 13;
        // question013.questionName = "rhinoceros";
        // question013.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros");
        // question013.answerOptions.Add("dog");
        // question013.answerOptions.Add("rhinoceros");
        // question013.answerOptions.Add("mouse");
        // question013.answerOptions.Add("ant");

        // questions.Add(question013);

        // question014.number = 14;
        // question014.questionName = "duck";
        // question014.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Duck");
        // question014.answerOptions.Add("rhinoceros");
        // question014.answerOptions.Add("horse");
        // question014.answerOptions.Add("mouse");
        // question014.answerOptions.Add("duck");

        // questions.Add(question014);

        // question015.number = 15;
        // question015.questionName = "pig";
        // question015.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Pig");
        // question015.answerOptions.Add("dog");
        // question015.answerOptions.Add("horse");
        // question015.answerOptions.Add("mouse");
        // question015.answerOptions.Add("pig");

        // questions.Add(question015);

        // question016.number = 16;
        // question016.questionName = "donkey";
        // question016.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Donkey");
        // question016.answerOptions.Add("dog");
        // question016.answerOptions.Add("horse");
        // question016.answerOptions.Add("donkey");
        // question016.answerOptions.Add("ant");

        // questions.Add(question016);

        // question017.number = 17;
        // question017.questionName = "rabbit";
        // question017.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit");
        // question017.answerOptions.Add("dog");
        // question017.answerOptions.Add("horse");
        // question017.answerOptions.Add("rabbit");
        // question017.answerOptions.Add("ant");

        // questions.Add(question017);

        // question018.number = 18;
        // question018.questionName = "frog";
        // question018.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Frog");
        // question018.answerOptions.Add("dog");
        // question018.answerOptions.Add("horse");
        // question018.answerOptions.Add("mouse");
        // question018.answerOptions.Add("frog");

        // questions.Add(question018);

        // question019.number = 19;
        // question019.questionName = "tiger";
        // question019.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Tiger");
        // question019.answerOptions.Add("tiger");
        // question019.answerOptions.Add("horse");
        // question019.answerOptions.Add("mouse");
        // question019.answerOptions.Add("ant");

        // questions.Add(question019);

        // question020.number = 20;
        // question020.questionName = "goat";
        // question020.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Goat");
        // question020.answerOptions.Add("dog");
        // question020.answerOptions.Add("horse");
        // question020.answerOptions.Add("mouse");
        // question020.answerOptions.Add("goat");

        // questions.Add(question020);

        // question021.number = 21;
        // question021.questionName = "chicken";
        // question021.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Chicken");
        // question021.answerOptions.Add("dog");
        // question021.answerOptions.Add("chicken");
        // question021.answerOptions.Add("mouse");
        // question021.answerOptions.Add("ant");

        // questions.Add(question021);

        // question022.number = 22;
        // question022.questionName = "elephant";
        // question022.sprite = Resources.Load<Sprite>("SimpleApp/Questions/Elephant");
        // question022.answerOptions.Add("dog");
        // question022.answerOptions.Add("elephant");
        // question022.answerOptions.Add("mouse");
        // question022.answerOptions.Add("ant");

        // questions.Add(question022);



        // questions[1].number = 2;
        // questions[1].questionName = "dog";
        // questions[1].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog");
        // questions[1].answerOptions.Add("mouse");
        // questions[1].answerOptions.Add("cat");
        // questions[1].answerOptions.Add("duck");
        // questions[1].answerOptions.Add("dog");
        // questions[1].tags.Add("animals");
        // questions[1].knownByLearner = false;

        // questions[2].number = 3;
        // questions[2].questionName = "horse";
        // questions[2].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse");
        // questions[2].answerOptions.Add("dog");
        // questions[2].answerOptions.Add("horse");
        // questions[2].answerOptions.Add("mouse");
        // questions[2].answerOptions.Add("ant");
        // questions[2].tags.Add("animals");
        // questions[2].knownByLearner = false;

        // questions[3].number = 4;
        // questions[3].questionName = "bear";
        // questions[3].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Bear");
        // questions[3].answerOptions.Add("bear");
        // questions[3].answerOptions.Add("horse");
        // questions[3].answerOptions.Add("mouse");
        // questions[3].answerOptions.Add("ant");
        // questions[3].tags.Add("animals");
        // questions[3].knownByLearner = false;

        // questions[4].number = 5;
        // questions[4].questionName = "wolf";
        // questions[4].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf");
        // questions[4].answerOptions.Add("bear");
        // questions[4].answerOptions.Add("wolf");
        // questions[4].answerOptions.Add("mouse");
        // questions[4].answerOptions.Add("ant");
        // questions[4].tags.Add("animals");
        // questions[4].knownByLearner = false;

        // questions[5].number = 6;
        // questions[5].questionName = "zebra";
        // questions[5].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Zebra");
        // questions[5].answerOptions.Add("dog");
        // questions[5].answerOptions.Add("horse");
        // questions[5].answerOptions.Add("mouse");
        // questions[5].answerOptions.Add("zebra");
        // questions[5].tags.Add("animals");
        // questions[5].knownByLearner = false;

        // questions[6].number = 7;
        // questions[6].questionName = "owl";
        // questions[6].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl");
        // questions[6].answerOptions.Add("dog");
        // questions[6].answerOptions.Add("horse");
        // questions[6].answerOptions.Add("owl");
        // questions[6].answerOptions.Add("zebra");
        // questions[6].tags.Add("animals");
        // questions[6].knownByLearner = false;

        // questions[7].number = 8;
        // questions[7].questionName = "monkey";
        // questions[7].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Monkey");
        // questions[7].answerOptions.Add("monkey");
        // questions[7].answerOptions.Add("horse");
        // questions[7].answerOptions.Add("owl");
        // questions[7].answerOptions.Add("zebra");
        // questions[7].tags.Add("animals");
        // questions[7].knownByLearner = false;

        // questions[8].number = 9;
        // questions[8].questionName = "squirrel";
        // questions[8].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel");
        // questions[8].answerOptions.Add("monkey");
        // questions[8].answerOptions.Add("squirrel");
        // questions[8].answerOptions.Add("owl");
        // questions[8].answerOptions.Add("zebra");
        // questions[8].tags.Add("animals");
        // questions[8].knownByLearner = false;

        // questions[9].number = 10;
        // questions[9].questionName = "giraffe";
        // questions[9].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe");
        // questions[9].answerOptions.Add("monkey");
        // questions[9].answerOptions.Add("squirrel");
        // questions[9].answerOptions.Add("owl");
        // questions[9].answerOptions.Add("giraffe");
        // questions[9].tags.Add("animals");
        // questions[9].knownByLearner = false;

        // questions[10].number = 11;
        // questions[10].questionName = "lion";
        // questions[10].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Lion");
        // questions[10].answerOptions.Add("monkey");
        // questions[10].answerOptions.Add("squirrel");
        // questions[10].answerOptions.Add("lion");
        // questions[10].answerOptions.Add("giraffe");
        // questions[10].tags.Add("animals");
        // questions[10].knownByLearner = false;

        // questions[11].number = 12;
        // questions[11].questionName = "alligator";
        // questions[11].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Alligator");
        // questions[11].answerOptions.Add("alligator");
        // questions[11].answerOptions.Add("squirrel");
        // questions[11].answerOptions.Add("lion");
        // questions[11].answerOptions.Add("giraffe");
        // questions[11].tags.Add("animals");
        // questions[11].knownByLearner = false;

        // questions[12].number = 13;
        // questions[12].questionName = "rhinoceros";
        // questions[12].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros");
        // questions[12].answerOptions.Add("alligator");
        // questions[12].answerOptions.Add("rhinoceros");
        // questions[12].answerOptions.Add("lion");
        // questions[12].answerOptions.Add("giraffe");
        // questions[12].tags.Add("animals");
        // questions[12].knownByLearner = false;

        // questions[13].number = 14;
        // questions[13].questionName = "duck";
        // questions[13].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Duck");
        // questions[13].answerOptions.Add("alligator");
        // questions[13].answerOptions.Add("rhinoceros");
        // questions[13].answerOptions.Add("lion");
        // questions[13].answerOptions.Add("duck");
        // questions[13].tags.Add("animals");
        // questions[13].knownByLearner = false;

        // questions[14].number = 15;
        // questions[14].questionName = "pig";
        // questions[14].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Pig");
        // questions[14].answerOptions.Add("alligator");
        // questions[14].answerOptions.Add("rhinoceros");
        // questions[14].answerOptions.Add("lion");
        // questions[14].answerOptions.Add("pig");
        // questions[14].tags.Add("animals");
        // questions[14].knownByLearner = false;

        // questions[15].number = 16;
        // questions[15].questionName = "donkey";
        // questions[15].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Donkey");
        // questions[15].answerOptions.Add("alligator");
        // questions[15].answerOptions.Add("rhinoceros");
        // questions[15].answerOptions.Add("donkey");
        // questions[15].answerOptions.Add("pig");
        // questions[15].tags.Add("animals");
        // questions[15].knownByLearner = false;

        // questions[16].number = 17;
        // questions[16].questionName = "rabbit";
        // questions[16].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit");
        // questions[16].answerOptions.Add("alligator");
        // questions[16].answerOptions.Add("rhinoceros");
        // questions[16].answerOptions.Add("rabbit");
        // questions[16].answerOptions.Add("pig");
        // questions[16].tags.Add("animals");
        // questions[16].knownByLearner = false;

        // questions[17].number = 18;
        // questions[17].questionName = "frog";
        // questions[17].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Frog");
        // questions[17].answerOptions.Add("alligator");
        // questions[17].answerOptions.Add("rhinoceros");
        // questions[17].answerOptions.Add("rabbit");
        // questions[17].answerOptions.Add("frog");
        // questions[17].tags.Add("animals");
        // questions[17].knownByLearner = false;

        // questions[18].number = 19;
        // questions[18].questionName = "tiger";
        // questions[18].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Tiger");
        // questions[18].answerOptions.Add("tiger");
        // questions[18].answerOptions.Add("rhinoceros");
        // questions[18].answerOptions.Add("rabbit");
        // questions[18].answerOptions.Add("frog");
        // questions[18].tags.Add("animals");
        // questions[18].knownByLearner = false;

        // questions[19].number = 20;
        // questions[19].questionName = "goat";
        // questions[19].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Goat");
        // questions[19].answerOptions.Add("tiger");
        // questions[19].answerOptions.Add("rhinoceros");
        // questions[19].answerOptions.Add("rabbit");
        // questions[19].answerOptions.Add("goat");
        // questions[19].tags.Add("animals");
        // questions[19].knownByLearner = false;

        // questions[20].number = 21;
        // questions[20].questionName = "chicken";
        // questions[20].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Chicken");
        // questions[20].answerOptions.Add("tiger");
        // questions[20].answerOptions.Add("chicken");
        // questions[20].answerOptions.Add("rabbit");
        // questions[20].answerOptions.Add("goat");
        // questions[20].tags.Add("animals");
        // questions[20].knownByLearner = false;

        // questions[21].number = 22;
        // questions[21].questionName = "elephant";
        // questions[21].sprite = Resources.Load<Sprite>("SimpleApp/Questions/Elephant");
        // questions[21].answerOptions.Add("tiger");
        // questions[21].answerOptions.Add("elephant");
        // questions[21].answerOptions.Add("rabbit");
        // questions[21].answerOptions.Add("goat");
        // questions[21].tags.Add("animals");
        // questions[21].knownByLearner = false;


        questions.Add(animal001);
        questions.Add(animal002);
        questions.Add(animal003);
        questions.Add(animal004);
        questions.Add(animal005);
        questions.Add(animal006);
        questions.Add(animal007);

    }




}

