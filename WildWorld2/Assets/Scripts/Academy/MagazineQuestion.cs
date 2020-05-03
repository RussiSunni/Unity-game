using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3, question4;
    int questionNumber = 1;

    public GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z;

    private void Start()
    {

        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/magazine01");
        question2 = Resources.Load<Sprite>("academy/magazine02");
        question3 = Resources.Load<Sprite>("academy/magazine03");
        question4 = Resources.Load<Sprite>("academy/magazine04");
        rend.sprite = question1;


        if (Progress.lettersExerciseComplete == false)
        {
            a = GameObject.Find("a");
            a.SetActive(false);
            b = GameObject.Find("b");
            b.SetActive(false);
            c = GameObject.Find("c");
            c.SetActive(false);
            d = GameObject.Find("d");
            d.SetActive(false);
            e = GameObject.Find("e");
            e.SetActive(false);
            f = GameObject.Find("f");
            f.SetActive(false);
            g = GameObject.Find("g");
            g.SetActive(false);
            h = GameObject.Find("h");
            h.SetActive(false);
            i = GameObject.Find("i");
            i.SetActive(false);
            j = GameObject.Find("j");
            j.SetActive(false);
            k = GameObject.Find("k");
            k.SetActive(false);
            l = GameObject.Find("l");
            l.SetActive(false);
            m = GameObject.Find("m");
            m.SetActive(false);
            n = GameObject.Find("n");
            n.SetActive(false);
            o = GameObject.Find("o");
            o.SetActive(false);
            p = GameObject.Find("p");
            p.SetActive(false);
            q = GameObject.Find("q");
            q.SetActive(false);
            r = GameObject.Find("r");
            r.SetActive(false);
            s = GameObject.Find("s");
            s.SetActive(false);
            t = GameObject.Find("t");
            t.SetActive(false);
            u = GameObject.Find("u");
            u.SetActive(false);
            v = GameObject.Find("v");
            v.SetActive(false);
            w = GameObject.Find("w");
            w.SetActive(false);
            x = GameObject.Find("x");
            x.SetActive(false);
            y = GameObject.Find("y");
            y.SetActive(false);
            z = GameObject.Find("z");
            z.SetActive(false);
        }
    }

    public void ChangeQuestion()
    {
        questionNumber++;

        if (questionNumber == 2)
        {
            rend.sprite = question2;
        }
        else if (questionNumber == 3)
        {
            rend.sprite = question3;
        }
        else if (questionNumber == 4)
        {
            rend.sprite = question4;
        }

    }
}


