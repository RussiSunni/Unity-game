using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SueDialogue : MonoBehaviour
{
    public static GameObject SueDialogueBox;
    void Start()
    {
        SueDialogueBox = GameObject.Find("Sue Dialogue");
        SueDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        SueDialogueBox.SetActive(true);
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
