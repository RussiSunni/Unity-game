using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EvaDialogue : MonoBehaviour
{
    public static GameObject EvaDialogueBox;
    void Start()
    {
        EvaDialogueBox = GameObject.Find("Eva Dialogue");
        EvaDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        EvaDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        EvaDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        EvaPlayerDialogue.DisplayDialogue();
        DisplayDialogueOff();
        // Hello_UI.suelocked = false;
        // Hello_UI.ReturnToInitialPosition();
    }
}
