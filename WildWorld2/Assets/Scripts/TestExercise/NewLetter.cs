using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewLetter : MonoBehaviour
{
    private SpriteRenderer rend;

    private Sprite letter01, letter02, letter03;

    private bool soundPlaying;

    GameObject fairy, fairyAnimation;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        letter01 = Resources.Load<Sprite>("CATNewLetter");

        soundPlaying = false;

        fairy = GameObject.Find("Fairy");
        fairyAnimation = GameObject.Find("Fairy animation");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(C.locked);
        if (C.locked && A.locked && T.locked)
        {
            rend.sprite = letter01;
            fairy.SetActive(false);
            fairyAnimation.SetActive(true);

            if (soundPlaying == false)
            {
                SoundManagerScript.playNewWordSound();
                soundPlaying = true;
            }
        }
        else
        {
            rend.sprite = null;
        }

    }
}
