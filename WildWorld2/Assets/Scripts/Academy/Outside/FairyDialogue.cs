using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue : MonoBehaviour
{
    public static GameObject FairyDialogueBox;
    void Start()
    {
        FairyDialogueBox = GameObject.Find("Fairy Dialogue");
        FairyDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        FairyDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        FairyDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        PlayerDialogue.DisplayDialogue();
        FairyDialogueBox.SetActive(false);
    }
}
