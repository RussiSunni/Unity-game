using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();

    void Start()
    {
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
        },
            tags = new List<string>()
        {
            "animals"
        }
        };

        SimpleQuestion animal002 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal003 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal004 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf"),
            answerOptions = new List<string>()
        {
            "dog",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        }
        };

        SimpleQuestion animal006 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal007 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal008 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal009 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal010 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal011 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal012 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal013 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal014 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal015 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal016 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal017 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal018 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal019 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal020 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal021 = new SimpleQuestion()
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
        }
        };

        SimpleQuestion animal022 = new SimpleQuestion()
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
        }
        };

        questions.Add(animal001);
        questions.Add(animal002);
        questions.Add(animal003);
        questions.Add(animal004);
        questions.Add(animal005);
        questions.Add(animal006);
        questions.Add(animal007);
        questions.Add(animal008);
        questions.Add(animal009);
        questions.Add(animal010);
        questions.Add(animal011);
        questions.Add(animal012);
        questions.Add(animal013);
        questions.Add(animal014);
        questions.Add(animal015);
        questions.Add(animal016);
        questions.Add(animal017);
        questions.Add(animal018);
        questions.Add(animal019);
        questions.Add(animal020);
        questions.Add(animal021);
        questions.Add(animal022);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();


        SimpleQuestion family001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "sister",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sister"),
            answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "mother",
            "father"
        },
            tags = new List<string>()
        {
            "family"
        },
            size = 2
        };

        questions.Add(family001);

        SimpleQuestion family002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "mother",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mother"),
            answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "mother",
            "father"
        },
            tags = new List<string>()
        {
            "family"
        },
            size = 2
        };

        questions.Add(family002);

        SimpleQuestion family003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "family",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Family"),
            answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "father"
        },
            tags = new List<string>()
        {
            "family"
        },
            size = 2
        };

        questions.Add(family003);

        SimpleQuestion verb001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "reading",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Reading"),
            answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "reading"
        },
            tags = new List<string>()
        {
            "verbs"
        },
            size = 2
        };

        questions.Add(verb001);

        SimpleQuestion verb002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "think",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Think"),
            answerOptions = new List<string>()
        {
            "think",
            "brother",
            "family",
            "reading"
        },
            tags = new List<string>()
        {
            "verbs"
        },
            size = 2
        };

        questions.Add(verb002);

        SimpleQuestion verb003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "sleep",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sleep"),
            answerOptions = new List<string>()
        {
            "think",
            "brother",
            "sleep",
            "reading"
        },
            tags = new List<string>()
        {
            "verbs"
        },
            size = 2
        };

        questions.Add(verb003);

        SimpleQuestion verb004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "wake up",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wake up"),
            answerOptions = new List<string>()
        {
            "think",
            "wake up",
            "sleep",
            "reading"
        },
            tags = new List<string>()
        {
            "verbs"
        },
            size = 2
        };

        questions.Add(verb004);

        SimpleQuestion verb005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "deliver",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Deliver"),
            answerOptions = new List<string>()
        {
            "think",
            "wake up",
            "sleep",
            "deliver"
        },
            tags = new List<string>()
        {
            "verbs"
        },
            size = 2
        };

        questions.Add(verb005);

        SimpleQuestion communicationsAndTechnology001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "mobile phone",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mobile phone"),
            answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "mobile phone"
        },
            tags = new List<string>()
        {
            "Communications and Technology"
        },
            size = 2
        };

        questions.Add(communicationsAndTechnology001);

    }
}

