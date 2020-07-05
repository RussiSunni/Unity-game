using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayPlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        MayPlayerDialogue.DisplayDialogueOff();
        MayDialogue.DisplayDialogue();

        // Hello_UI.ReturnToInitialPosition();
        // Sue_UI.ReturnToInitialPosition();
    }
}
