using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue : MonoBehaviour
{
    public static GameObject FairyDialogueBox, FairyDialogueBox2;
    void Start()
    {
        FairyDialogueBox = GameObject.Find("Fairy Dialogue");
        FairyDialogueBox.SetActive(false);

        FairyDialogueBox2 = GameObject.Find("Fairy Dialogue 2");
        FairyDialogueBox2.SetActive(false);


    }

    public static void DisplayDialogue()
    {
        FairyDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        FairyDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue2()
    {
        FairyDialogueBox2.SetActive(true);
    }


    public void OnMouseDown()
    {
        FairyPlayerDialogue.DisplayDialogue();
        FairyDialogueBox.SetActive(false);
        Hello_UI.fairyLocked = false;
        Hello_UI.ReturnToInitialPosition();
    }
}
