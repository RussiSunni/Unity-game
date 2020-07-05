using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayPlayerDialogue : MonoBehaviour
{
    public static int answer;
    public static GameObject PlayerDialogueBox;
    void Start()
    {
        PlayerDialogueBox = GameObject.Find("May Player Dialogue");
        PlayerDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        PlayerDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        PlayerDialogueBox.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (answer == 2)
        {
            PlayerDialogueBox.SetActive(false);
            SueDialogue.DisplayDialogueOff();
            SoundManagerScript.playCorrectSound();

            Hello_UI.ReturnToInitialPosition();
            Sue_UI.ReturnToInitialPosition();
        }
    }
}
