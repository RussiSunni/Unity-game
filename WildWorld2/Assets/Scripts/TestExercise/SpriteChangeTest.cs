using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteChangeTest : MonoBehaviour
{
    public static SpriteRenderer rend;

    public static Sprite fairy01, fairy02, fairy03, fairy04;



    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        fairy01 = Resources.Load<Sprite>("fairy01");
        fairy02 = Resources.Load<Sprite>("fairy02");
        fairy03 = Resources.Load<Sprite>("fairy03");
        fairy04 = Resources.Load<Sprite>("fairy04");
        rend.sprite = fairy01;


    }

    // Update is called once per frame
    void Update()
    {

        if (TestExerciseNext.catFlag == false)
        {
            // if (A.pressed || C.pressed || T.pressed)
            // {
            //     rend.sprite = fairy02;
            // }

            // else if (B.pressed || D.pressed || E.pressed || F.pressed || G.pressed || H.pressed || I.pressed || J.pressed || K.pressed || L.pressed || M.pressed || N.pressed || O.pressed || P.pressed || Q.pressed || R.pressed || S.pressed || U.pressed || V.pressed || W.pressed || X.pressed || Y.pressed || Z.pressed)
            // {
            //     rend.sprite = fairy01;
            // }

        }
        if (TestExerciseNext.catFlag)
        {
            if (D.pressed || O.pressed || G.pressed)
            {
                rend.sprite = fairy02;
            }

            else
            {
                rend.sprite = fairy01;
            }
        }
    }
}
