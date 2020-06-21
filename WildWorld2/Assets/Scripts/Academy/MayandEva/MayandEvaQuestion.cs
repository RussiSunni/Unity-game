using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayandEvaQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2;
    GameObject targetblock1, targetblock2, mayHitBox, evaHitBox;
    public static GameObject successText;
    int slideNumber;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/03");
        question2 = Resources.Load<Sprite>("academy/04");
        rend.sprite = question1;

        targetblock1 = GameObject.Find("target_block-1");
        targetblock2 = GameObject.Find("target_block-2");
        mayHitBox = GameObject.Find("MayHitBox");
        evaHitBox = GameObject.Find("EvaHitBox");

        successText = GameObject.Find("SuccessText");
        successText.SetActive(false);

        slideNumber = 1;
    }

    void Update()
    {
        if (slideNumber == 1)
        {
            rend.sprite = question1;
            // targetblock1.SetActive(false);
            // targetblock2.SetActive(false);
        }
        if (slideNumber == 2)
        {
            rend.sprite = question2;
        }

        if (May.correctPosition && Eva.correctPosition)
            Success();


    }
    public void slideForward()
    {
        if (slideNumber < 2)
        {
            slideNumber++;
            targetblock1.SetActive(true);
            targetblock2.SetActive(true);
            mayHitBox.SetActive(false);
            evaHitBox.SetActive(false);
        }
    }
    public void slideBackward()
    {
        if (slideNumber > 1)
        {
            slideNumber--;
            mayHitBox.SetActive(true);
            evaHitBox.SetActive(true);
        }
    }

    public static void Success()
    {
        successText.SetActive(true);
        Progress.dictionaryEva = true;
        Progress.dictionaryMay = true;

        Progress.eva = false;
        Progress.may = false;
    }

}
