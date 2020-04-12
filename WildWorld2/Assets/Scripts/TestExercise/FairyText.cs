using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairyText : MonoBehaviour
{
    // Start is called before the first frame update

    Text fairyText;

    void Start()
    {
        fairyText = GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.textNumber == 0)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 1)
        {
            fairyText.text = "Ok, she said something about knowing the animal's names.";
        }
        else if (TestExerciseNext.textNumber == 2)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 3)
        {
            fairyText.text = "Hmmm, she referred to it as 'Sir Barksalot. Maybe that is a clue.'";
        }
        else if (TestExerciseNext.textNumber == 4)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 5)
        {
            fairyText.text = "I dont give a hoot!";
        }
        else if (TestExerciseNext.textNumber == 99)
        {
            fairyText.text = "Wait, isnt it 'dog'?";
        }
    }
}
