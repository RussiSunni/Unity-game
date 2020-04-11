using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlockFour : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite question1, question2, question3;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("cat_target_block");
        question2 = Resources.Load<Sprite>("dog_target_block");
        question3 = Resources.Load<Sprite>("owl_target_block");
        rend.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (TestExerciseNext.owlFlag)
        {
            rend.sprite = question3;
        }
    }
}
