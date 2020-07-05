using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaPlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        EvaPlayerDialogue.DisplayDialogueOff();
        EvaDialogue.DisplayDialogue();

        // Hello_UI.ReturnToInitialPosition();
        // Sue_UI.ReturnToInitialPosition();
    }
}
