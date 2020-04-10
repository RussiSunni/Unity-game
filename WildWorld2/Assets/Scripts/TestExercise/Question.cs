using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite question1, question2, question3;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("cat");
        question2 = Resources.Load<Sprite>("dog");
        question3 = Resources.Load<Sprite>("owl");
        rend.sprite = question1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = question2;
        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = question3;
        }
    }
}
