using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreetingQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3, question4, question5, question6;

    GameObject hello, my1, name1, is1, may, hi, may2, my2, name2, is2, eva, targetblock1, targetblock2;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/03");
        question2 = Resources.Load<Sprite>("academy/04");
        // question3 = Resources.Load<Sprite>("academy/introducing03");
        // question4 = Resources.Load<Sprite>("academy/introducing04");
        // question5 = Resources.Load<Sprite>("academy/introducing05");
        // question6 = Resources.Load<Sprite>("academy/introducing06");

        rend.sprite = question1;

        hello = GameObject.Find("HELLO");
        my1 = GameObject.Find("MY 1");
        name1 = GameObject.Find("NAME 1");
        is1 = GameObject.Find("IS 1");
        may = GameObject.Find("MAY 1");

        hi = GameObject.Find("HI");
        may2 = GameObject.Find("MAY 2");
        my2 = GameObject.Find("MY 2");
        name2 = GameObject.Find("NAME 2");
        is2 = GameObject.Find("IS 2");
        eva = GameObject.Find("EVA");

        targetblock1 = GameObject.Find("TargetBlock1");
        targetblock2 = GameObject.Find("TargetBlock2");
        targetblock1.SetActive(false);
        targetblock2.SetActive(false);
    }

    void Update()
    {
        if (Next.questionNumber == 2)
        {
            rend.sprite = question2;
            // hello.transform.position = new Vector2(-8, 3.3f);
            // my1.transform.position = new Vector2(-8, 2.4f);
            // name1.transform.position = new Vector2(-8, 1.5f);
            // is1.transform.position = new Vector2(-8, 0.6f);
            // may.transform.position = new Vector2(-8, -0.3f);

            // hi.transform.position = new Vector2(8, 3.3f);
            // may2.transform.position = new Vector2(8, 2.4f);
            // my2.transform.position = new Vector2(8, 1.5f);
            // name2.transform.position = new Vector2(8, 0.6f);
            // is2.transform.position = new Vector2(8, -0.3f);
            // eva.transform.position = new Vector2(8, -1.2f);

            hello.SetActive(false);
            my1.SetActive(false);
            name1.SetActive(false);
            is1.SetActive(false);

            hi.SetActive(false);
            may2.SetActive(false);
            my2.SetActive(false);
            name2.SetActive(false);
            is2.SetActive(false);


            targetblock1.SetActive(true);
            targetblock2.SetActive(true);
        }
        if (Next.questionNumber == 3)
        {
            rend.sprite = question3;
        }
        if (Next.questionNumber == 4)
        {
            rend.sprite = question4;
        }
        if (Next.questionNumber == 5)
        {
            rend.sprite = question5;
        }
        if (Next.questionNumber == 6)
        {
            rend.sprite = question6;
        }
    }
}
