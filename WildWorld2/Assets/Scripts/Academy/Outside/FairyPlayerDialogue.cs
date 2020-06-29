using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyPlayerDialogue : MonoBehaviour
{
    public static bool answer;
    public static GameObject PlayerDialogueBox;
    void Start()
    {
        PlayerDialogueBox = GameObject.Find("Player Dialogue");
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
        if (answer)
        {
            PlayerDialogueBox.SetActive(false);
            FairyDialogue.DisplayDialogueOff();
            SoundManagerScript.playCorrectSound();

            Hello_UI.ReturnToInitialPosition();

            DoorSpawn.MakeActive();
        }
    }
}
