using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlocks : MonoBehaviour
{
    private Vector2 mousePosition;

    private float deltaX, deltaY;

    GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, CAT, DOG, OWL;

    private bool book;


    // Start is called before the first frame update
    void Start()
    {
        book = true;


        a = GameObject.Find("a-block");
        b = GameObject.Find("b-block");
        c = GameObject.Find("c-block");
        d = GameObject.Find("d-block");
        e = GameObject.Find("e-block");
        f = GameObject.Find("f-block");
        g = GameObject.Find("g-block");
        h = GameObject.Find("h-block");
        i = GameObject.Find("i-block");
        j = GameObject.Find("j-block");
        k = GameObject.Find("k-block");
        l = GameObject.Find("l-block");
        m = GameObject.Find("m-block");
        n = GameObject.Find("n-block");
        o = GameObject.Find("o-block");
        p = GameObject.Find("p-block");
        q = GameObject.Find("q-block");
        r = GameObject.Find("r-block");
        s = GameObject.Find("s-block");
        t = GameObject.Find("t-block");
        u = GameObject.Find("u-block");
        v = GameObject.Find("v-block");
        w = GameObject.Find("w-block");
        x = GameObject.Find("x-block");
        y = GameObject.Find("y-block");
        z = GameObject.Find("z-block");

        CAT = GameObject.Find("CAT");
        DOG = GameObject.Find("DOG");
        OWL = GameObject.Find("OWL");
    }

    private void OnMouseDown()
    {

        if (book)
        {
            book = false;

            if (A.destroyed == false && A.locked == false)
            {
                a.SetActive(false);
            }
            if (B.destroyed == false && B.locked == false)
            {
                b.SetActive(false);
            }
            if (C.destroyed == false && C.locked == false)
            {
                c.SetActive(false);
            }
            if (D.destroyed == false && D.locked == false)
            {
                d.SetActive(false);
            }
            if (E.destroyed == false && E.locked == false)
            {
                e.SetActive(false);
            }
            if (F.destroyed == false && F.locked == false)
            {
                f.SetActive(false);
            }
            if (G.destroyed == false && G.locked == false)
            {
                g.SetActive(false);
            }
            if (H.destroyed == false && H.locked == false)
            {
                h.SetActive(false);
            }
            if (I.destroyed == false && I.locked == false)
            {
                i.SetActive(false);
            }
            if (J.destroyed == false && J.locked == false)
            {
                j.SetActive(false);
            }
            if (K.destroyed == false && K.locked == false)
            {
                k.SetActive(false);
            }
            if (L.destroyed == false && L.locked == false)
            {
                l.SetActive(false);
            }
            if (M.destroyed == false && M.locked == false)
            {
                m.SetActive(false);
            }
            if (N.destroyed == false && N.locked == false)
            {
                n.SetActive(false);
            }
            if (O.destroyed == false && O.locked == false)
            {
                o.SetActive(false);
            }
            if (P.destroyed == false && P.locked == false)
            {
                p.SetActive(false);
            }
            if (Q.destroyed == false && Q.locked == false)
            {
                q.SetActive(false);
            }
            if (R.destroyed == false && R.locked == false)
            {
                r.SetActive(false);
            }
            if (S.destroyed == false && S.locked == false)
            {
                s.SetActive(false);
            }
            if (T.destroyed == false && T.locked == false)
            {
                t.SetActive(false);
            }
            if (U.destroyed == false && U.locked == false)
            {
                u.SetActive(false);
            }
            if (V.destroyed == false && V.locked == false)
            {
                v.SetActive(false);
            }
            if (W.destroyed == false && W.locked == false)
            {
                w.SetActive(false);
            }
            if (X.destroyed == false && X.locked == false)
            {
                x.SetActive(false);
            }
            if (Y.destroyed == false && Y.locked == false)
            {
                y.SetActive(false);
            }
            if (Z.destroyed == false && X.locked == false)
            {
                z.SetActive(false);
            }


            if (TestExerciseNext.catFlag)
            {
                CAT.SetActive(true);
            }

            if (TestExerciseNext.dogFlag)
            {
                DOG.SetActive(true);
            }

            if (TestExerciseNext.owlFlag)
            {
                OWL.SetActive(true);
            }

        }
        else
        {
            book = true;

            if (A.destroyed == false)
            {
                a.SetActive(true);
            }
            if (A.destroyed == false)
            {
                a.SetActive(true);
            }
            if (B.destroyed == false)
            {
                b.SetActive(true);
            }
            if (C.destroyed == false)
            {
                c.SetActive(true);
            }
            if (D.destroyed == false)
            {
                d.SetActive(true);
            }
            if (E.destroyed == false)
            {
                e.SetActive(true);
            }
            if (F.destroyed == false)
            {
                f.SetActive(true);
            }
            if (G.destroyed == false)
            {
                g.SetActive(true);
            }
            if (H.destroyed == false)
            {
                h.SetActive(true);
            }
            if (I.destroyed == false)
            {
                i.SetActive(true);
            }
            if (J.destroyed == false)
            {
                j.SetActive(true);
            }
            if (K.destroyed == false)
            {
                k.SetActive(true);
            }
            if (L.destroyed == false)
            {
                l.SetActive(true);
            }
            if (M.destroyed == false)
            {
                m.SetActive(true);
            }
            if (N.destroyed == false)
            {
                n.SetActive(true);
            }
            if (O.destroyed == false)
            {
                o.SetActive(true);
            }
            if (P.destroyed == false)
            {
                p.SetActive(true);
            }
            if (Q.destroyed == false)
            {
                q.SetActive(true);
            }
            if (R.destroyed == false)
            {
                r.SetActive(true);
            }
            if (S.destroyed == false)
            {
                s.SetActive(true);
            }
            if (T.destroyed == false)
            {
                t.SetActive(true);
            }
            if (U.destroyed == false)
            {
                u.SetActive(true);
            }
            if (V.destroyed == false)
            {
                v.SetActive(true);
            }
            if (W.destroyed == false)
            {
                w.SetActive(true);
            }
            if (X.destroyed == false)
            {
                x.SetActive(true);
            }
            if (Y.destroyed == false)
            {
                y.SetActive(true);
            }
            if (Z.destroyed == false)
            {
                z.SetActive(true);
            }

            CAT.SetActive(false);
            DOG.SetActive(false);
            OWL.SetActive(false);
        }
    }


    private void OnMouseUp()
    {
    }

}
