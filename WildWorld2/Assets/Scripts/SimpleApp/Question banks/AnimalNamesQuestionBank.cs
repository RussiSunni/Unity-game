using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalNamesQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animal001 = new SimpleQuestion();
    public static SimpleQuestion animal002 = new SimpleQuestion();
    public static SimpleQuestion animal003 = new SimpleQuestion();
    public static SimpleQuestion animal004 = new SimpleQuestion();
    public static SimpleQuestion animal005 = new SimpleQuestion();
    public static SimpleQuestion animal006 = new SimpleQuestion();
    public static SimpleQuestion animal007 = new SimpleQuestion();
    public static SimpleQuestion animal008 = new SimpleQuestion();
    public static SimpleQuestion animal009 = new SimpleQuestion();
    public static SimpleQuestion animal010 = new SimpleQuestion();
    public static SimpleQuestion animal011 = new SimpleQuestion();
    public static SimpleQuestion animal012 = new SimpleQuestion();
    public static SimpleQuestion animal013 = new SimpleQuestion();
    public static SimpleQuestion animal014 = new SimpleQuestion();
    public static SimpleQuestion animal015 = new SimpleQuestion();
    public static SimpleQuestion animal016 = new SimpleQuestion();
    public static SimpleQuestion animal017 = new SimpleQuestion();
    public static SimpleQuestion animal018 = new SimpleQuestion();
    public static SimpleQuestion animal019 = new SimpleQuestion();
    public static SimpleQuestion animal020 = new SimpleQuestion();
    public static SimpleQuestion animal021 = new SimpleQuestion();
    public static SimpleQuestion animal022 = new SimpleQuestion();
    public static SimpleQuestion animal023 = new SimpleQuestion();

    void Start()
    {
        animal001 = new SimpleQuestion()
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
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog"),
            answerOptions = new List<string>()
        {
            "mouse",
            "cat",
            "duck",
            "dog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal008 = new SimpleQuestion()
        {
            number = 8,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal009 = new SimpleQuestion()
        {
            number = 9,
            questionName = "squirrel",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel"),
            answerOptions = new List<string>()
        {
            "monkey",
            "squirrel",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal010 = new SimpleQuestion()
        {
            number = 10,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "squirrel",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal011 = new SimpleQuestion()
        {
            number = 11,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal012 = new SimpleQuestion()
        {
            number = 12,
            questionName = "alligator",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Alligator"),
            answerOptions = new List<string>()
        {
            "alligator",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal013 = new SimpleQuestion()
        {
            number = 13,
            questionName = "rhinoceros",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal014 = new SimpleQuestion()
        {
            number = 14,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Duck"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "lion",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal015 = new SimpleQuestion()
        {
            number = 15,
            questionName = "pig",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Pig"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "pig",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal016 = new SimpleQuestion()
        {
            number = 16,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Donkey"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal017 = new SimpleQuestion()
        {
            number = 17,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "squirrel",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal018 = new SimpleQuestion()
        {
            number = 18,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "squirrel",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal019 = new SimpleQuestion()
        {
            number = 19,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal020 = new SimpleQuestion()
        {
            number = 20,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Goat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "goat",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal021 = new SimpleQuestion()
        {
            number = 21,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Chicken"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal022 = new SimpleQuestion()
        {
            number = 22,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animal023 = new SimpleQuestion()
        {
            number = 23,
            questionName = "iguana",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Iguana"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "iguana"
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
        if (GameControl.animal001known == false)
            questions.Add(animal001);

        if (!GameControl.animal002known)
            questions.Add(animal002);

        if (!GameControl.animal003known)
            questions.Add(animal003);

        if (!GameControl.animal004known)
            questions.Add(animal004);

        if (!GameControl.animal005known)
            questions.Add(animal005);

        if (!GameControl.animal006known)
            questions.Add(animal006);

        if (!GameControl.animal007known)
            questions.Add(animal007);

        if (!GameControl.animal008known)
            questions.Add(animal008);

        if (!GameControl.animal009known)
            questions.Add(animal009);

        if (!GameControl.animal010known)
            questions.Add(animal010);

        if (!GameControl.animal011known)
            questions.Add(animal011);

        if (!GameControl.animal012known)
            questions.Add(animal012);

        if (!GameControl.animal013known)
            questions.Add(animal013);

        if (!GameControl.animal014known)
            questions.Add(animal014);

        if (!GameControl.animal015known)
            questions.Add(animal015);

        if (!GameControl.animal016known)
            questions.Add(animal016);

        if (!GameControl.animal017known)
            questions.Add(animal017);

        if (!GameControl.animal018known)
            questions.Add(animal018);

        if (!GameControl.animal019known)
            questions.Add(animal019);

        if (!GameControl.animal020known)
            questions.Add(animal020);

        if (!GameControl.animal021known)
            questions.Add(animal021);

        if (!GameControl.animal022known)
            questions.Add(animal022);

        if (!GameControl.animal023known)
            questions.Add(animal023);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        Debug.Log(questions.Count);
    }
}

