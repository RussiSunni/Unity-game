using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewLetter : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite letter01, letter02, letter03;

    //  private bool soundPlaying;

    GameObject fairy, fairyAnimation;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        letter01 = Resources.Load<Sprite>("CATNewBlock");
        letter02 = Resources.Load<Sprite>("DOGNewBlock");
        letter03 = Resources.Load<Sprite>("OWLNewBlock");

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

            // if (soundPlaying == false)
            // {
            //     SoundManagerScript.playNewWordSound();
            //     soundPlaying = true;
            // }
        }

        else if (O.locked && W.locked && L.locked)
        {
            rend.sprite = letter03;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

            // if (soundPlaying == false)
            // {
            //     SoundManagerScript.playNewWordSound();
            //     soundPlaying = true;
            // }
        }
        else
        {
            rend.sprite = null;
        }

    }
}
