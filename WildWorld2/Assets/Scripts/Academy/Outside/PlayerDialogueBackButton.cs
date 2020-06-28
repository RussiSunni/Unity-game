using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        PlayerDialogue.DisplayDialogueOff();
        FairyDialogue.DisplayDialogue();

        Hello_UI.ReturnToInitialPosition();
    }
}
