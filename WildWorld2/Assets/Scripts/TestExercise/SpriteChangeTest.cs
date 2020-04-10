using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteChangeTest : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite fairy01, fairy02, fairy03;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        fairy01 = Resources.Load<Sprite>("fairy01");
        fairy02 = Resources.Load<Sprite>("fairy02");
        fairy03 = Resources.Load<Sprite>("fairy03");
        rend.sprite = fairy01;
    }

    // Update is called once per frame
    void Update()
    {



        if (A.pressed || C.pressed || T.pressed)
        {
            rend.sprite = fairy02;
        }
        else
        {
            rend.sprite = fairy01;
        }
        if (C.locked && A.locked && T.locked)
        {
            rend.sprite = fairy03;
        }

    }
}
