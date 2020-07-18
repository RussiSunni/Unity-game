using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SueDialogue : MonoBehaviour
{
    public static GameObject SueDialogueBox, sueCard, hiCard;
    void Start()
    {
        SueDialogueBox = GameObject.Find("Sue Dialogue");
        SueDialogueBox.SetActive(false);

        sueCard = GameObject.Find("SUE");
        sueCard.SetActive(false);

        hiCard = GameObject.Find("HI");
        hiCard.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        SueDialogueBox.SetActive(true);


        if (Progress.sue == false)
        {
            sueCard.SetActive(true);
            SoundManagerScript.playSUEWordSound();
        }

        if (Progress.hi == false)
        {
            SoundManagerScript.playHIWordSound();
            hiCard.SetActive(true);
        }
    }

    public static void DisplayDialogueOff()
    {
        SueDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        SuePlayerDialogue.DisplayDialogue();
        DisplayDialogueOff();
        Hello_UI.suelocked = false;
        Hello_UI.ReturnToInitialPosition();
    }
}
