using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewLetter : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite letter01, letter02, letter03, letter04, letter05;

    //  private bool soundPlaying;

    GameObject fairy, fairyAnimation;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        letter01 = Resources.Load<Sprite>("CATNewBlock");
        letter02 = Resources.Load<Sprite>("DOGNewBlock");
        letter03 = Resources.Load<Sprite>("OWLNewBlock");
        letter04 = Resources.Load<Sprite>("BEARNewBlock");
        letter05 = Resources.Load<Sprite>("WOLFNewBlock");

        // soundPlaying = false;

        fairy = GameObject.Find("Fairy");
        fairyAnimation = GameObject.Find("Fairy animation");
    }

    // Update is called once per frame
    void Update()
    {

        if (C.locked && A.locked && T.locked)
        {
            rend.sprite = letter01;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

            // if (soundPlaying == false)
            // {
            //     SoundManagerScript.playNewWordSound();
            //     soundPlaying = true;
            // }
        }

        else if (D.locked && O.locked && G.locked)
        {
            rend.sprite = letter02;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

        }

        else if (O.locked && W.locked && L.locked && !F.locked)
        {
            rend.sprite = letter03;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

        }
        else if (B.locked && E.locked && A.locked && R.locked)
        {
            rend.sprite = letter04;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

        }
        else if (W.locked && O.locked && L.locked && F.locked)
        {
            rend.sprite = letter05;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);
        }
        else
        {
            rend.sprite = null;
        }

    }
}
