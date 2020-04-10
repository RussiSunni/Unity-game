using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlocks : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite question1, question2;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("cat_target_block");
        question2 = Resources.Load<Sprite>("dog_target_block");
        rend.sprite = question1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = question2;
        }
    }
}
