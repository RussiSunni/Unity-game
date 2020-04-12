using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtemisText : MonoBehaviour
{
    Text artemisText;

    void Start()
    {
        artemisText = GetComponent<Text>();
        artemisText.text = "";
    }

    void Update()
    {
        if (TestExerciseNext.textNumber == 0)
        {
            artemisText.text = "I summon thee,  Meowser.";
        }
        else if (TestExerciseNext.textNumber == 1)
        {
            artemisText.text = "";
        }
        else if (TestExerciseNext.textNumber == 2)
        {
            artemisText.text = "How do you know so much? Lets see if you can tame Sir Barksalot.";
        }
        else if (TestExerciseNext.textNumber == 3)
        {
            artemisText.text = "";
        }
        else if (TestExerciseNext.textNumber == 4)
        {
            artemisText.text = "I doubt you are wise enough to know this one!";
        }
        else if (TestExerciseNext.textNumber == 5)
        {
            artemisText.text = "";
        }
    }
}
